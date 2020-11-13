using System;
using System.Collections.Generic;
using System.Text;

namespace Cpts321
{
    public class TextChangeCommand : ChangeCommand
    {
        private TextChange change;

        public TextChangeCommand(TextChange newchange)
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
