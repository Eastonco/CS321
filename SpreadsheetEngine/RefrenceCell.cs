using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SpreadsheetEngine
{
    class RefrenceCell : SpreadsheetCell
    {
        public RefrenceCell(int row, int column, Spreadsheet Parent) : base(row, column) {
            ParentSpreadsheet = Parent;
        }

        private Spreadsheet ParentSpreadsheet;

        public override string Evaluate(string input)
        {
            var target = this.ParentSpreadsheet.GetCell(input);

            target.PropertyChanged += (sender, e) => this.NotifyPropertyChanged(nameof(this.Value));

            if(target == null)
            {
                return null;
            }

            return target.Value;
        }

    }
}
