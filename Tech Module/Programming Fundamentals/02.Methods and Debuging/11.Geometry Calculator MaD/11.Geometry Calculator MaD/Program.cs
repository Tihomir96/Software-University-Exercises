using System;

namespace _11.Geometry_Calculator_MaD
{
    class Program
    {
        static void Main()
        {
            string figureType = Console.ReadLine();
            

            if (figureType == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(FormatArea(TriangleArea(a, b)));

            }
            else if (figureType == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(FormatArea(SquareArea(a)));
            }
            else if (figureType == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(FormatArea(RectangleArea(a,b)));
            }
            else if (figureType == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(FormatArea(CircleArea(a)));
            }


        }

        public static double TriangleArea (double a,double hA)
        {
            return RectangleArea(a, hA) / 2;
        }
        public static double SquareArea (double a)
        {
            return RectangleArea(a,a);
        }
        public static double RectangleArea (double a, double b)
        {
            return a * b;
        }
        public static double CircleArea (double a)
        {
            return Math.PI * SquareArea(a);
        }
        public static string FormatArea(double area)
        {
            return Math.Round(area, 2).ToString("0.00");
        }

    }
}
