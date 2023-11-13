using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Component_1_Assignment.Components;

namespace Component_1_Assignment.BasicCommands
{
    internal class ColorHandler : Icommands
    {
        string _color;
        public ColorHandler(string color) { 
            _color = color;
            execute();

        }
        public void execute()
        {
            switch (_color)
            {
                case "black":
                    GlobalConfiguration.penColor = Color.Black;
                    break;
                case "red":
                    GlobalConfiguration.penColor = Color.Red;
                    break;
                case "blue":
                    GlobalConfiguration.penColor = Color.Blue;
                    break;
                case "green":
                    GlobalConfiguration.penColor = Color.Green;
                    break;
                case "yellow":
                    GlobalConfiguration.penColor = Color.Yellow;
                    break;
                case "orange":
                    GlobalConfiguration.penColor= Color.Orange;
                    break;
                case "lime":
                    GlobalConfiguration.penColor = Color.LightGreen;
                    break;
                case "coral":
                    GlobalConfiguration.penColor = Color.Coral;
                    break;
                case "white":
                    GlobalConfiguration.penColor = Color.White;
                    break;
                default:
                    MessageBox.Show("Invalid color, Please enter the correct Color.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
                    

            }
           
        }
    }
}
