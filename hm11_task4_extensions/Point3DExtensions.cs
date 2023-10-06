using hm11_task4_extensions.hm11_task4_extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm11_task4_extensions
{
    internal static class Point3DExtensions
    {
        public static double CalculateDistance(this Point3D point1, Point3D point2)
        {
            double deltaX = point1.X - point2.X;
            double deltaY = point1.Y - point2.Y;
            double deltaZ = point1.Z - point2.Z;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }

        public static double CalculateMaxDistance(this Point3D[] point)
        {
            double maxDistance = 0;

            Point3D pointA;
            Point3D pointB;

            for (int i = 0; i < point.Length; i++)
            {
                for (int j = i + 1; j < point.Length; j++)
                {
                    double distance = point[i].CalculateDistance(point[j]);

                    if (distance > maxDistance)
                    {
                        maxDistance = distance;

                        pointA = point[i];
                        pointB = point[j];
                    }
                }
            }

            return maxDistance;
        }
    }
}
