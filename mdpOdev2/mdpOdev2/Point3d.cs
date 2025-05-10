using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdpOdev2
{
    public class Point3d : Point
    {
        int z;
        public Point3d() : base()
        { Z = 0; }
        public Point3d(int x, int y, int z)
        { Z = z; }
        public int Z { get => z; set => z = value; }
    }

}
