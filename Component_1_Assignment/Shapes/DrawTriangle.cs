﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component_1_Assignment.Components;

namespace Component_1_Assignment.Shapes
{
    internal class DrawTriangle: Icommands
    {
        private int sideX;
        //private int sideY;
        private Graphics g;
        public DrawTriangle(int sideX, Graphics graphics)
        {
            this.sideX = sideX;
         
            this.g = graphics;

            execute();
        }

        public void execute()
        {
            int centerX = (int)(g.VisibleClipBounds.Width / 2);
            int centerY = (int)g.VisibleClipBounds.Height / 2;
            int halfLengthX = sideX / 2;
            int height = (int)(Math.Sqrt(3) / 2 * sideX);

            Point[] points = new Point[]
            {
                new Point(centerX, centerY - height / 2),         
                new Point(centerX - halfLengthX, centerY + height / 2), 
                new Point(centerX + halfLengthX, centerY + height / 2)  
            };

            Pen pen = new Pen(GlobalConfiguration.penColor);
            SolidBrush brush = new SolidBrush(GlobalConfiguration.penColor);

            if (GlobalConfiguration.isFillOn)
            {
                g.FillPolygon(brush, points);
            }
            else
            {
                g.DrawPolygon(pen, points);
            }
        }
    }
}
