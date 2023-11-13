using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component_1_Assignment.Components;

namespace Component_1_Assignment.Shapes
{
    internal class DrawRectangle : Icommands
    {
        private int posX;
        private int posY;
        private int width;
        private int height;
        private Graphics g;


        public DrawRectangle(int posX, int posY, int width, int height, Graphics g) 
        {
            this.posX = posX;
            this.posY = posY;
            this.width = width; 
            this.height = height;
            this.g = g;

            execute();
        }
        public void execute()
        {
            try
            {
                Pen pen = new Pen(GlobalConfiguration.penColor);
                SolidBrush brush = new SolidBrush(GlobalConfiguration.penColor);

                if (GlobalConfiguration.isFillOn)
                {
                    g.FillRectangle(brush, posX, posY, width, height);
                }
                else
                {
                    g.DrawRectangle(pen, posX, posY, width, height);
                }




            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
