using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component_1_Assignment.Components;

namespace Component_1_Assignment.Shapes
{
    internal class DrawCircle: Icommands
    {
        private int radius;
        private Graphics graphics;
        public DrawCircle(int radius, Graphics graphics) 
        {
            this.radius = radius;
            this.graphics = graphics;

            execute();
        }
        
        public void execute()
        {
            Pen pen = new Pen(GlobalConfiguration.penColor);
            SolidBrush brush = new SolidBrush(GlobalConfiguration.penColor);

            if (GlobalConfiguration.isFillOn)
            {
                graphics.FillEllipse(brush, 200, 200, radius, radius);
            }
            else
            {
                graphics.DrawEllipse(pen, 200, 200, radius, radius);
            }

           
        }
    }
}
