using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdpOdev2
{
    public class Circle
    {
        Point m; int r;
        public Circle()
        {
            M = new Point();// merkez noktası
            R = 0;
        }
        public Circle(Point p, int r)
        {
            M = p;
            R = r;
        }

        public int R { get => r; set => r = value; }
        internal Point M { get => m; set => m = value; }
    }


}
