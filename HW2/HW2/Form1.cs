// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HW2
{
    using System;
    using System.Text;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SortIntegers sorter = new SortIntegers();
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("1. Hashset Method: {0} distinct integers", sorter.HashDistinct());
            sb.AppendLine();
            sb.Append("\tThis algorithm has an O(2n) time complexity which is reduced to");
            sb.AppendLine();
            sb.Append("\tO(n) since it loops through the list twice but loops are not nested.");
            sb.AppendLine();
            sb.AppendFormat("2. O(1) storage: {0} distinct integers", sorter.SpaceDistinct());
            sb.AppendLine();
            sb.AppendFormat("3. Sorted method: {0} distinct integers", sorter.SortDistinct());

            this.textBox1.Text = sb.ToString();
        }
    }
}
