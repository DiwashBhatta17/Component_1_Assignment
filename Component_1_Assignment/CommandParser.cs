using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component_1_Assignment
{
    internal class CommandParser
    {
        private string[] commands;

        public CommandParser(string commands) 
        { 
            this.commands = commands.Split(' ',' ');
            classCaller();

           
        }
        private void classCaller()
        {
            if (this.commands[0].ToLower() == "moveto")
            {
                // new MoveTo(commands[1],commands[2]);
            }

            else if (this.commands[0].ToLower() == "drawto")
            {
                // new DrawTo(commands[1],commands[2]);
            }
            else if (this.commands[0].ToLower() == "fill")
            {
                // new FillColor(commands[1]);
            }
            else if (this.commands[0].ToLower() == "rectangle")
            {
                // new Rectangle(commands[1],commands[2]);
            }
            else if(this.commands[0].ToLower() == "circle")
            {
                // new Circle(commands[1]);
            }
            else if (this.commands[0].ToLower() == "triangle")
            {
                // new Triangle(commands[1]);
            }
            else
            {
                MessageBox.Show("Invalid Command ! please Enter the correct command", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


    }

   
}
