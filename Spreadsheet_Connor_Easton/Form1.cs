using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spreadsheet_Connor_Easton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.CancelEdit();
            dataGridView1.Columns.Clear();

            for(char column = 'A'; column <= 'Z'; column++)
            {
                dataGridView1.Columns.Add("Column " + column, column.ToString());
            }
            dataGridView1.Rows.Add(50);
            for(int row = 1; row <= 50; row++)
            {
                dataGridView1.Rows[row - 1].HeaderCell.Value = row.ToString();
            }

        }
    }
}
