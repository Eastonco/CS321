using System;
using System.Collections.Generic;
using System.Text;

namespace Cpts321
{
    public class TextChange
    {
        private SpreadsheetCell cell;
        private string before;
        private string after;

        public TextChange(ref SpreadsheetCell cell, string oldval, string newval)
        {
            this.cell = cell;
            if (oldval == null) {
                this.before = string.Empty;
            } 
            else 
            {
                this.before = oldval;
            }

            if(newval == null)
            {
                this.after = string.Empty;
            }
            else
            {
                this.after = newval;
            }
        }

        internal void undo()
        {
            this.cell.Text = this.before;
        }

        internal void redo()
        {
            this.cell.Text = this.after;
        }
    }
}
