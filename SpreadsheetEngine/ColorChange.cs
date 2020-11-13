using System;
using System.Collections.Generic;
using System.Text;

namespace Cpts321
{
    public class ColorChange
    {
        private List<SpreadsheetCell> cells = new List<SpreadsheetCell>();
        private List<uint> before = new List<uint>();
        private List<uint> after = new List<uint>();

        public ColorChange()
        {
        }

        public void AddCell(ref SpreadsheetCell newcell, uint oldcolor, uint newcolor)
        {
            this.cells.Add(newcell);
            this.before.Add(oldcolor);
            this.after.Add(newcolor);
        }

        internal void undo()
        {
            int i = 0;
            foreach (SpreadsheetCell cell in this.cells)
            {
                cell.BGColor = this.before[i];
                i++;
            }
        }

        internal void redo()
        {
            int i = 0;
            foreach (SpreadsheetCell cell in this.cells)
            {
                cell.BGColor = this.after[i];
                i++;
            }
        }
    }
}
