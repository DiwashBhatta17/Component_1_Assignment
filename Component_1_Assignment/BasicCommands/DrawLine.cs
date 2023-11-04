using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component_1_Assignment.Components;

namespace Component_1_Assignment.BasicCommands
{
    internal class DrawLine: Icommands
    {
        private int posX = GlobalConfiguration.xPoint;
        private int posY = GlobalConfiguration.yPoint;
        private Graphics g;
        private int endX;
        private int endY;
        public DrawLine( int endX, int endY, Graphics g) 
        {
          
            this.g = g;
            this.endX = endX;   
            this.endY = endY;

            execute();
        }

        public void execute()
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(Pens.Black, posX, posY, endX, endY);
        }
    }
}
