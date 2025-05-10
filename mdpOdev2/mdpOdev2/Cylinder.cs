using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdpOdev2
{
    public class Cylinder
    {
        Point3d m;
        int r; //  silindirin çapı olacak 
        int h;
        public Cylinder()
        {
            M = new Point3d();// merkez noktası
            R = 0;
            H = 0;
        }
        public Cylinder(Point3d p, int r, int h)
        {
            M = p;
            R = r;
            H = h;
        }

        public int R { get => r; set => r = value; }
        public int H { get => h; set => h = value; }
        internal Point3d M { get => m; set => m = value; }
    }

}
