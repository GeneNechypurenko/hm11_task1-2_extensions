using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm11_task4_extensions
{
    internal record Point3D
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Point3D()
        {
            Random random = new Random();
            X = random.Next(0, 10);
            Y = random.Next(0, 10);
            Z = random.Next(0, 10);
        }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
