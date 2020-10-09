using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace SpreadsheetEngine
{
    public abstract class SpreadsheetCell : INotifyPropertyChanged
    {
        public SpreadsheetCell(int row, int column)
        {
            this.rowIndex = row;
            this.ColumnIndex = column;
            this._text = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public int rowIndex { get; }
        public int ColumnIndex { get; }
        protected string _text;
        public string Text {
            get
            {
                return this._text;
            }
            set
            {
                if(value == this._text)
                {
                    return;
                }
                else
                {
                    this._text = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Value
        {
            get
            {
                if (this.Text.StartsWith("="))
                {
                    return this.Evaluate(this.Text.Substring(1));
                }
                else
                {
                    return this.Text;
                }
            }
        }

        abstract public string Evaluate(string input);

    }
}
