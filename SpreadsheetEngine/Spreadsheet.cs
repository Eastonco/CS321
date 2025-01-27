﻿// <copyright file="Spreadsheet.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using System.ComponentModel;
using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Xml;
using System.IO;


namespace Cpts321
{
    /// <summary>
    /// main spreadsheet class.
    /// </summary>
    public class Spreadsheet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Spreadsheet"/> class.
        /// </summary>
        /// <param name="rows">row index.</param>
        /// <param name="columns">column index.</param>
        public Spreadsheet(int rows, int columns)
        {
            this.Sheet = new SpreadsheetCell[rows, columns];
            this.ColumnCount = columns;
            this.RowCount = rows;
            this.UndoEmpty = true;
            this.RedoEmpty = true;
            this.UndoStack.Clear();
            this.RedoStack.Clear();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    this.Sheet[i, j] = new RefrenceCell(i, j, this);
                    this.Sheet[i, j].PropertyChanged += this.PropertyCellChanged;
                }
            }
        }

        /// <summary>
        /// evnet handeler.
        /// </summary>
        public event PropertyChangedEventHandler CellPropertyChanged;

        /// <summary>
        /// propty update call.
        /// </summary>
        /// <param name="sender">object.</param>
        /// <param name="e">args.</param>
        private void PropertyCellChanged(object sender, PropertyChangedEventArgs e)
        {
            this.CellPropertyChanged?.Invoke(sender, e);

            RefrenceCell c = sender as RefrenceCell;
        }

        /// <summary>
        /// internal refrence cell.
        /// </summary>
        private class RefrenceCell : SpreadsheetCell
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="RefrenceCell"/> class.
            /// </summary>
            /// <param name="row">row index.</param>
            /// <param name="column">column index.</param>
            /// <param name="parent">parent spreadsheet.</param>
            public RefrenceCell(int row, int column, Spreadsheet parent)
                : base(row, column)
            {
                this.parentSpreadsheet = parent;
            }

            /// <summary>
            /// parent spreadsheet.
            /// </summary>
            private Spreadsheet parentSpreadsheet;

            /// <summary>
            /// evalue the cell.
            /// </summary>
            /// <param name="input">input location.</param>
            /// <returns>the value.</returns>
            public override string Evaluate(string input)
            {
                ExpressionTree exp = new ExpressionTree(input);
                string pattern = @"[A-Z](?:50|[1-4][0-9]|[1-9])";

                SpreadsheetCell target;

                foreach (Match m in Regex.Matches(input, pattern))
                {
                    try
                    {
                        target = this.parentSpreadsheet.GetCell(m.Value);

                        exp.SetVariable(m.Value, Convert.ToDouble(target.Value));

                        target.PropertyChanged += (sender, e) => this.NotifyPropertyChanged(nameof(this.Value));
                        target.PropertyChanged += this.RefrencePropertyChanged;
                    }
                    catch
                    {
                        return "!CellNotDefined";
                    }

                }

                return exp.Evaluate().ToString();
            }

            /// <summary>
            /// update refrence property.
            /// </summary>
            /// <param name="sender">sender.</param>
            /// <param name="e">e.</param>
            private void RefrencePropertyChanged(object sender, PropertyChangedEventArgs e)
            {
                SpreadsheetCell cell = (SpreadsheetCell)sender;
                this.Value = this.parentSpreadsheet.GetCell(cell.RowIndex, cell.ColumnIndex).Value;
            }

            /// <summary>
            /// Gets or sets value override.
            /// </summary>
            public override string Value
            {
                get
                {
                    return this._value;
                }

                set
                {
                    if (this._text.StartsWith("="))
                    {
                        this._value = this.Evaluate(this.Text.Substring(1));
                    }
                    else
                    {
                        this._value = this._text;
                    }
                }
            }
        }

        /// <summary>
        /// sheet.
        /// </summary>
        public SpreadsheetCell[,] Sheet;

        /// <summary>
        /// Gets column count.
        /// </summary>
        public int ColumnCount { get; set; }

        /// <summary>
        /// Gets row count.
        /// </summary>
        public int RowCount { get; set; }

        public Stack<ChangeCommand> UndoStack = new Stack<ChangeCommand>();

        public Stack<ChangeCommand> RedoStack = new Stack<ChangeCommand>();

        /// <summary>
        /// Gets or sets a value indicating whether gets if undo stack is empty.
        /// </summary>
        public bool UndoEmpty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets if redo stack is empty
        /// </summary>
        public bool RedoEmpty { get; set; }

        /// <summary>
        /// gets the cell from string locaiton.
        /// </summary>
        /// <param name="location">location string.</param>
        /// <returns>cell.</returns>
        public SpreadsheetCell GetCell(string location)
        {
            char column = location[0];
            int columnNum = column - 'A' + 1;
            var row = int.Parse(location.Substring(1));

            return this.Sheet[row - 1, columnNum - 1];
        }

        public void UndoAction()
        {
            if (!this.UndoEmpty)
            {
                ChangeCommand command = this.UndoStack.Pop();
                command.Undo();
                this.RedoStack.Push(command);
                this.RedoEmpty = false;
            }

            if(this.UndoStack.Count == 0)
            {
                this.UndoEmpty = true;
            }
            else
            {
                this.UndoEmpty = false;
            }
        }

        public void RedoAction()
        {
            if (!this.RedoEmpty)
            {
                ChangeCommand command = this.RedoStack.Pop();
                command.Redo();
                this.UndoStack.Push(command);
                this.UndoEmpty = false;
            }

            if (this.RedoStack.Count == 0)
            {
                this.RedoEmpty = true;
            }
            else
            {
                this.RedoEmpty = false;
            }
        }

        public void SaveSpreadsheet(Stream outfile)
        {
            XmlWriter xmlWriter = XmlWriter.Create(outfile);
            xmlWriter.WriteStartElement("spreadsheet");
            xmlWriter.WriteAttributeString("columns", this.ColumnCount.ToString());
            xmlWriter.WriteAttributeString("rows", this.RowCount.ToString());

            foreach (SpreadsheetCell cell in this.Sheet) 
            {
                if (!IsDefaultCell(cell)) 
                {
                    cell.WriteXml(xmlWriter);  
                }
            }
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }

        private bool IsDefaultCell(SpreadsheetCell cell)
        {
            return cell.Text == string.Empty && cell.BGColor == 0xFFFFFFFF;
        }


        /// <summary>
        /// Loads a file given a string.
        /// </summary>
        /// <param name="filename">filename.</param>
        public void LoadFile(Stream file)
        {
            int colcount = 26, rowcount = 50;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);

            foreach (XmlNode node in doc.DocumentElement.Attributes)
            {
                switch (node.Name)
                {
                    case "columns":
                        colcount = int.Parse(node.Value);
                        break;
                    case "rows":
                        rowcount = int.Parse(node.Value);
                        break;
                }
            }

            this.Reconstruct(rowcount, colcount);

            SpreadsheetCell cell = this.GetCell("A1");

            foreach (XmlNode node in doc.DocumentElement)
            {
                if(node.Name == "cell")
                {
                    foreach (XmlAttribute attribute in node.Attributes) //get the name 
                    {
                        if (attribute.Name == "name")
                        {
                            cell = this.GetCell(attribute.Value);
                            break;
                        }
                    }

                    foreach(XmlNode child in node.ChildNodes)
                    {
                        switch (child.Name)
                        {
                            case "bgcolor":
                                cell.BGColor = uint.Parse(child.InnerText);
                                break;
                            case "text":
                                cell.Text = child.InnerText;
                                break;
                        }
                    }



                }
            }



            /*
            while (textReader.Read())
            {
                if (textReader.Name == "spreadsheet")
                {
                    for (int i = 0; i < textReader.AttributeCount; i++)
                    {
                        textReader.MoveToAttribute(i);
                        switch (textReader.Name)
                        {
                            case "Colums":
                                int.TryParse(textReader.Value, out colcount);
                                break;
                            case "Rows":
                                int.TryParse(textReader.Value, out rowcount);
                                break;
                            default:
                                break;
                        }
                    }

                    this.Reconstruct(rowcount, colcount);
                }

                if (textReader.Name == "Cell")
                {
                    for (int i = 0; i < textReader.AttributeCount; i++)
                    {
                        textReader.MoveToAttribute(i);
                        switch (textReader.Name)
                        {
                            case "Name":
                                int.TryParse(textReader.Value, out colcount);
                                break;
                            case "Rows":
                                int.TryParse(textReader.Value, out rowcount);
                                break;
                            default:
                                break;
                        }
                    }

                    this.Reconstruct(rowcount, colcount);
                }
            }*/
        }

        /// <summary>
        /// gets the cell.
        /// </summary>
        /// <param name="row">at row index.</param>
        /// <param name="column">at column index.</param>
        /// <returns>the cell.</returns>
        public SpreadsheetCell GetCell(int row, int column)
        {
            return this.Sheet[row, column];
        }

        private void Reconstruct(int rows, int columns)
        {
            this.Sheet = new SpreadsheetCell[rows, columns];
            this.ColumnCount = columns;
            this.RowCount = rows;
            this.UndoEmpty = true;
            this.RedoEmpty = true;
            this.UndoStack.Clear();
            this.RedoStack.Clear();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    this.Sheet[i, j] = new RefrenceCell(i, j, this);
                    this.Sheet[i, j].PropertyChanged += this.PropertyCellChanged;
                }
            }
        }
    }
}
