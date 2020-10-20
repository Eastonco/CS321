// <copyright file="SpreadsheetCell.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Cpts321
{
    /// <summary>
    /// main cell class.
    /// </summary>
    public abstract class SpreadsheetCell : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetCell"/> class.
        /// </summary>
        /// <param name="row">row.</param>
        /// <param name="column">column.</param>
        public SpreadsheetCell(int row, int column)
        {
            this.RowIndex = row;
            this.ColumnIndex = column;
            this.Text = string.Empty;
        }

        /// <summary>
        /// property changed event.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Update property changed.
        /// </summary>
        /// <param name="propertyName">property name.</param>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if (this._text.StartsWith("="))
            {
                this._value = this.Evaluate(this.Text.Substring(1));
            }
            else
            {
                this._value = this._text;
            }
        }

        /// <summary>
        /// Gets row index.
        /// </summary>
        public int RowIndex { get; }

        /// <summary>
        /// Gets column index.
        /// </summary>
        public int ColumnIndex { get; }

        /// <summary>
        /// private value.
        /// </summary>
        protected string _value;

        /// <summary>
        /// private text.
        /// </summary>
        protected string _text;

        /// <summary>
        /// Text.
        /// </summary>
        public string Text
        {
            get
            {
                return this._text;
            }

            set
            {
                if (value == this._text)
                {
                    return;
                }
                else
                {
                    this._text = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Value.
        /// </summary>
        public virtual string Value
        {
            get
            {
                return this._value;
            }

            set
            {
                return;
            }
        }

        public abstract string Evaluate(string input);
    }
}
