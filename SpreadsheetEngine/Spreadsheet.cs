﻿// <copyright file="Spreadsheet.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System.ComponentModel;

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
                var target = this.parentSpreadsheet.GetCell(input);

                target.PropertyChanged += (sender, e) => this.NotifyPropertyChanged(nameof(this.Value));
                target.PropertyChanged += this.RefrencePropertyChanged;

                if (target == null)
                {
                    return null;
                }

                return target.Value;
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
        public int ColumnCount { get; }

        /// <summary>
        /// Gets row count.
        /// </summary>
        public int RowCount { get; }

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
    }
}
