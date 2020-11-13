// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Spreadsheet_Connor_Easton
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Cpts321;

    /// <summary>
    /// Base form.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// main engine.
        /// </summary>
        private readonly Cpts321.Spreadsheet engine;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
            this.engine = new Cpts321.Spreadsheet(50, 26);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.CancelEdit();
            this.dataGridView1.Columns.Clear();

            for (char column = 'A'; column <= 'Z'; column++)
            {
                this.dataGridView1.Columns.Add("Column " + column, column.ToString());
            }

            this.dataGridView1.Rows.Add(50);

            for (int row = 1; row <= 50; row++)
            {
                this.dataGridView1.Rows[row - 1].HeaderCell.Value = row.ToString();
            }

            this.engine.CellPropertyChanged += this.SpreadsheetChangedEvent;
            this.undoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Enabled = false;
        }

        private void SpreadsheetChangedEvent(object sender, PropertyChangedEventArgs e)
        {
            SpreadsheetCell cell = (SpreadsheetCell)sender;
            this.dataGridView1[cell.ColumnIndex, cell.RowIndex].Value = this.engine.Sheet[cell.RowIndex, cell.ColumnIndex].Value;
            this.dataGridView1[cell.ColumnIndex, cell.RowIndex].Style.BackColor = Color.FromArgb((int)(this.engine.Sheet[cell.RowIndex, cell.ColumnIndex].BGColor));
        }

        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = this.engine.Sheet[e.RowIndex, e.ColumnIndex].Text;
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SpreadsheetCell cell = this.engine.Sheet[e.RowIndex, e.ColumnIndex];
            TextChange newchange = new TextChange(ref cell, cell.Text, this.dataGridView1[e.ColumnIndex, e.RowIndex].Value?.ToString());
            this.engine.UndoStack.Push(new TextChangeCommand(newchange));
            this.engine.UndoEmpty = false;
            this.undoToolStripMenuItem.Enabled = true;

            this.engine.Sheet[e.RowIndex, e.ColumnIndex].Text = this.dataGridView1[e.ColumnIndex, e.RowIndex].Value?.ToString() ?? string.Empty;
            this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = this.engine.Sheet[e.RowIndex, e.ColumnIndex].Value;
        }

        private void DemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                this.engine.Sheet[rand.Next(49), rand.Next(25)].Text = "Hello world!";
            }

            for (int i = 1; i < 50; i++)
            {
                this.engine.Sheet[i - 1, 1].Text = "This is cell B" + i;
                this.engine.Sheet[i - 1, 0].Text = "=B" + i;
            }
        }

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;

            // Update the text box color if the user clicks OK.

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                ColorChange changes = new ColorChange();
                foreach (DataGridViewCell cell in this.dataGridView1.SelectedCells)
                {
                    SpreadsheetCell engineCell = this.engine.Sheet[cell.RowIndex, cell.ColumnIndex];

                    changes.AddCell(ref engineCell, engineCell.BGColor, (uint)MyDialog.Color.ToArgb());

                    engineCell.BGColor = (uint)MyDialog.Color.ToArgb();
                }

                this.engine.UndoStack.Push(new ColorChangeCommand(changes));
                this.engine.UndoEmpty = false;
                this.undoToolStripMenuItem.Enabled = true;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.engine.UndoEmpty)
            {
                this.engine.UndoAction();
                this.redoToolStripMenuItem.Enabled = true;
            }
            if (this.engine.UndoEmpty)
            {
                this.undoToolStripMenuItem.Enabled = false;
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.engine.RedoEmpty)
            {
                this.engine.RedoAction();
                this.undoToolStripMenuItem.Enabled = true;
            }
            if (this.engine.RedoEmpty)
            {
                this.redoToolStripMenuItem.Enabled = false;
            }
        }
    }
}
