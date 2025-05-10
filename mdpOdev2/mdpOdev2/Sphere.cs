using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdpOdev2
{
    public class Sphere
    {
        Point3d m; int r;
        public Sphere()
        {
            M = new Point3d();// merkez noktası
            R = 0;
        }
        public Sphere(Point3d p, int r)
        {
            M = p;
            R = r;
        }

        public int R { get => r; set => r = value; }
        internal Point3d M { get => m; set => m = value; }
    }

}
