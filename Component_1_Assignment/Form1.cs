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
            if (textBox2.Text.ToLower() != "run" && textBox2.Text != "")
            {
                Graphics gCommandParser = panel1.CreateGraphics();
                new CommandParser(textBox2.Text, gCommandParser);
                gCommandParser.Dispose(); // Dispose the Graphics object used by CommandParser
            }

            if (textBox2.Text.ToLower() == "run")
            {
                Graphics gProgramHandler = panel1.CreateGraphics();
                gProgramHandler.Clear(panel1.BackColor);
                ProgramHandler p = new ProgramHandler(gProgramHandler);
                p.Execute(textBox1.Text);
                gProgramHandler.Dispose(); // Dispose the Graphics object used by ProgramHandler
            }
        }

        private void syntax_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
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
