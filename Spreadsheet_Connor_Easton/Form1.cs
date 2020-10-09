using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spreadsheet_Connor_Easton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Engine = new SpreadsheetEngine.Spreadsheet(50, 26);
        }

        public SpreadsheetEngine.Spreadsheet Engine;


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.CancelEdit();
            dataGridView1.Columns.Clear();

            for (char column = 'A'; column <= 'Z'; column++)
            {
                dataGridView1.Columns.Add("Column " + column, column.ToString());
            }
            dataGridView1.Rows.Add(50);
            for (int row = 1; row <= 50; row++)
            {
                dataGridView1.Rows[row - 1].HeaderCell.Value = row.ToString();
            }

            for (int i = 0; i < 49; i++)
            {
                for(int j = 0; j < 25; j++)
                {
                    Engine.sheet[i, j].PropertyChanged += (Cellsender, CellE) => dataGridView1[j, i].Value = ((SpreadsheetEngine.SpreadsheetCell)Cellsender).Value;
                }
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = Engine.sheet[e.RowIndex, e.ColumnIndex].Text;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Engine.sheet[e.RowIndex, e.ColumnIndex].Text = dataGridView1[e.ColumnIndex, e.RowIndex].Value?.ToString() ?? string.Empty;
            dataGridView1[e.ColumnIndex, e.RowIndex].Value = Engine.sheet[e.RowIndex, e.ColumnIndex].Value;
        }
    }
}
