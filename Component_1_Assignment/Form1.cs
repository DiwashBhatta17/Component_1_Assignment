using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component_1_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void run_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            // MessageBox.Show(textBox2.Text, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(textBox2.Text != "")
            {
                new CommandParser(textBox2.Text, g);
            }

            if (textBox1.Text != "")
            {
                string[] commands = textBox1.Lines; 
                foreach (string commandLine in commands)
                {
                    new CommandParser(commandLine, g); 
                }

            }
        }
        private void syntax_Click(object sender, EventArgs e)
        {

        }

     
    }
}
