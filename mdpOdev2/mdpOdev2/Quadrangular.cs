using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdpOdev2
{
    public class Prism
    {
        Point3d m;
        int width;
        int height;
        int depth;

        public Prism()
        {
            M = new Point3d();
            Width = 0;
            Height = 0;
            Depth = 0;
        }

        public Prism(Point3d m, int width, int height, int depth)
        {
            M = m;
            Width = width;
            Height = height;
            Depth = depth;
        }

        internal Point3d M { get => m; set => m = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public int Depth { get => depth; set => depth = value; }
    }
}
