using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Create an instance of a TextBox control.
            TextBox textBox1 = new TextBox();

            // Set the Multiline property to true.
            textBox1.Multiline = true;
            // Add vertical scroll bars to the TextBox control.
            textBox1.ScrollBars = ScrollBars.Vertical;
            // Allow the RETURN key to be entered in the TextBox control.
            textBox1.AcceptsReturn = true;
            // Allow the TAB key to be entered in the TextBox control.
            textBox1.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            textBox1.WordWrap = true;
            // Set the default text of the control.
            textBox1.Text = "Welcome!";
        }
    }
}
