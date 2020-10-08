using System;
using System.ComponentModel;
using System.Xml.Schema;

namespace CptS321
{
    public abstract class SpreadsheetCell : INotifyPropertyChanged
    {
        SpreadsheetCell()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public int rowIndex { get; }
        public int ColumnIndex { get; }
        protected string Text {
            get
            {
                return Text;
            }
            set
            {
                if(value == Text)
                {
                    return;
                }
                else
                {
                    Text = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
                }
            }
        }
        protected string Value { get; }
    }
}
