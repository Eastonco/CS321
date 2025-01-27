﻿// <copyright file="SpreadsheetCell.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml;


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
            this.BGColor = 0xFFFFFFFF;
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

            if (this._text.StartsWith("="))
            {
                this._value = this.Evaluate(this.Text.Substring(1));
            }
            else
            {
                this._value = this._text;
            }

            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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

        protected uint color;


        /// <summary>
        /// private text.
        /// </summary>
        protected string _text;

        /// <summary>
        /// Gets or sets text.
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
        /// Gets or sets value.
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

        /// <summary>
        /// Gets or sets BGColor.
        /// </summary>
        public uint BGColor
        {
            get
            {
                return this.color;
            }

            set
            {
                if (value == this.color)
                {
                    return;
                }
                else
                {
                    this.color = value;
                    this.NotifyPropertyChanged();
                }
            }
        }


        /// <summary>
        /// abstract evaluate method.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public abstract string Evaluate(string input);

        public void WriteXml(XmlWriter writer)
        {
            string location = (char)(this.ColumnIndex + 'A') + (this.RowIndex + 1).ToString();
            writer.WriteStartElement("cell");
            writer.WriteAttributeString("name", location);
            writer.WriteElementString("bgcolor", this.BGColor.ToString());
            writer.WriteElementString("text", this.Text);
            writer.WriteEndElement();
        }
    }
}
