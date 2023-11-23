using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Component_1_Assignment.Components;

namespace Component_1_Assignment.BasicCommands
{ 
    internal class MoveTo : Icommands
    {
       
        private Graphics g;
        private Font font;
        private Brush brush;
        private string indicatorSymbol = "*"; 

       
        public MoveTo(int x, int y, Graphics g)
        {
            GlobalConfiguration.xPoint = x;
            GlobalConfiguration.yPoint = y;
            this.g = g;

            font = new Font("Arial", 12); 
            brush = new SolidBrush(Color.Black); 



            execute();
        }

        public void execute()
        {

            Point newStartPoint = new Point(GlobalConfiguration.xPoint, GlobalConfiguration.yPoint);            
            g.DrawString(indicatorSymbol, font, brush, newStartPoint);
        }
    }
}
