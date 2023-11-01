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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void run_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(textBox2.Text, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new CommandParser(textBox2.Text);


        }

        private void syntax_Click(object sender, EventArgs e)
        {

        }
    }
}
