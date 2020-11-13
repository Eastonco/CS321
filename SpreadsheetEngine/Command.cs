using System;
using System.Collections.Generic;
using System.Text;

namespace Cpts321
{
    public interface ChangeCommand
    {
        void Redo();
        void Undo();
    }
}
