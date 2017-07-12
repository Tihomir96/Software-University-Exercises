using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(' ');
            var input2 = Console.ReadLine().Split(' ');

            var point1 = new Point(int.Parse(input[0]),int.Parse(input[1]));
            var point2 = new Point(int.Parse(input2[0]), int.Parse(input2[1]));


            var circle1 = new Circle();
            circle1.Center = point1;
            circle1.Radius = int.Parse(input[2]);
            var circle2 = new Circle();
            circle2.Center = point2;
            circle2.Radius = int.Parse(input2[2]);
            var d =Point.CalculateDistance(point1, point2);

            int sumOfRadiuses = circle1.Radius + circle2.Radius;

            if (d <= sumOfRadiuses)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
