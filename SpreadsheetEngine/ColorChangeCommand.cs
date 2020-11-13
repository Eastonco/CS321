using System;
using System.Collections.Generic;
using System.Text;

namespace Cpts321
{
    public class ColorChangeCommand : ChangeCommand
    {
        private ColorChange change;

        public ColorChangeCommand(ColorChange newchange)
        {
            this.change = newchange;
        }

        public void Undo()
        {
            this.change.undo();
        }

        public void Redo()
        {
            this.change.redo();
        }
    }
}
