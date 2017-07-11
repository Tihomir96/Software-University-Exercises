using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Intersection_of_Circles
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point (int x ,int y)
        {
            X = x;
            Y = y;

        }
        public static int CalculateDistance(Point p1, Point p2)
        {
            return (int)Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + ((p1.Y - p2.Y) * (p1.Y - p2.Y)));
        }
    }
}
