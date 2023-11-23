using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Component_1_Assignment.Components;

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

        private void save_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

             try
             {

                 FileHandler fileHandler = new FileHandler();
                 fileHandler.Save(textBox1.Text);

                 MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error while saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void load_Click(object sender, EventArgs e)
        {
            FileHandler fileHandler = new FileHandler();
            string text = fileHandler.Load();
            textBox1.Text = text;


        }
    }
}
