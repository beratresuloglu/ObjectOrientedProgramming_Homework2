using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdpOdev2
{
    public class Square
    {
        Point m;
        int edge;

        public Square()
        {
            M = new Point();
            Edge = 0;
        }

        public Square(Point p, int edge)
        {
            M = p;
            Edge = edge;
        }

        internal Point M { get => m; set => m = value; }
        public int Edge { get => edge; set => edge = value; }
    }
}
