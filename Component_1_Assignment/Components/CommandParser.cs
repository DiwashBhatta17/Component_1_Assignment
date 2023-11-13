using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Component_1_Assignment.BasicCommands;
using Component_1_Assignment.Components;
using Component_1_Assignment.Shapes;

namespace Component_1_Assignment
{

    internal class CommandParser
    {
        private string[] commands;
        private Graphics graphics;
      


        public CommandParser(string commands, Graphics g) 
        { 

            this.commands = commands.Trim().Split(' ',' ');
            this.graphics = g;
            classCaller();

           
        }
        private void classCaller()
        {
            if (this.commands[0].ToLower() == "moveto" && int.TryParse(commands[1], out int xAxis) && int.TryParse(commands[2], out int yAxis))
            {
                new MoveTo(xAxis, yAxis, graphics);
            }

            else if (commands[0].ToLower() == "drawto" && int.TryParse(commands[1], out int endX) && int.TryParse(commands[2], out int endY))
            {
                new DrawLine(endX, endY, graphics);
            }
            else if (commands[0].ToLower() == "fill" &&(commands[1].ToLower() == "on" || commands[1].ToLower() == "off"))
            {
                new Filled(commands[1]);
            }

            else if (commands[0].ToLower() == "color")
            {
                new ColorHandler(commands[1]);
            }

            else if (commands[0].ToLower() == "rectangle" &&
                int.TryParse(commands[1], out int posX) && int.TryParse(commands[2], out int posY)
                && int.TryParse(commands[3], out int width) && int.TryParse(commands[4], out int height) && commands.Length <= 5)
            {
                new DrawRectangle(posX, posY, width, height, this.graphics);
            }

            else if (this.commands[0].ToLower() == "circle" && int.TryParse(commands[1], out int radius) && commands.Length <=2)
            {
                new DrawCircle(radius, graphics);
            }

            else if (this.commands[0].ToLower() == "triangle" && int.TryParse(commands[1], out int sideA) && commands.Length <=2)
            {
                 new DrawTriangle(sideA,graphics);
            }

            else
            {
                MessageBox.Show("Invalid Command ! please Enter the correct command", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


    }

   
}
