using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdpOdev2
{
    public class Point
    {
        int x;
        int y;
        public Point()
        { X = 0; Y = 0; }
        public Point(int x, int y)
        { X = x; Y = y; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}

