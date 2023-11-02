using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            graphics.DrawEllipse(Pens.Black, 200, 200, radius, radius);
        }
    }
}
