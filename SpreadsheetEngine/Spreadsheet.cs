using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SpreadsheetEngine
{
    public class Spreadsheet 
    {
        public Spreadsheet(int rows, int columns)
        {
            sheet = new SpreadsheetCell[rows, columns];
            ColumnCount = columns;
            RowCount = rows;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    sheet[i, j] = new RefrenceCell(i, j, this);
                    sheet[i, j].PropertyChanged += (sender, e) => this.CellPropertyChanged?.Invoke(sender, e);
                }
            }
        }

        public SpreadsheetCell[,] sheet;
        public event PropertyChangedEventHandler CellPropertyChanged;
        public int ColumnCount { get; }
        public int RowCount { get; }

        public SpreadsheetCell GetCell(string location)
        {
            char column = location[0];
            int columnNum = column - 'A'  + 1;
            var row = Int32.Parse(location.Substring(1));

            return sheet[row-1, columnNum-1];
        }
    }
}
