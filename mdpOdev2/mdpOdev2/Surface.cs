using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdpOdev2
{
    public class Surface
    {
        Point3d m;
        int depth;
        int width;

        public Surface()
        {
            M = new Point3d();
            Depth = 0;
            Width = 0;
        }
        public Surface(Point3d m, int depth, int width)
        {
            M = m;
            Depth = depth;
            Width = width;
            
        }

        internal Point3d M { get => m; set => m = value; }
        public int Depth { get => depth; set => depth = value; }
        public int Width { get => width; set => width = value; }
    }
}
