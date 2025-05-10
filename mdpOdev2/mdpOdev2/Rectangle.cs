using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdpOdev2
{
    public class RectangleClass
    {
        Point m; int width; int height;
        public RectangleClass()
        {
            M = new Point(); //köşe noktası
            Width = 0;
            Height = 0;
        }
        public RectangleClass(Point p, int width, int height)
        {
            M = p;
            Width = width;
            Height = height;
        }
        internal Point M { get => m; set => m = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
    }
}


