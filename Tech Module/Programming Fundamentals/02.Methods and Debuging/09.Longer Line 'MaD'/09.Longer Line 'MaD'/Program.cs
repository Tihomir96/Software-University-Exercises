using System;


namespace _09.Longer_Line__MaD_
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            LongestLine( x1, y1,  x2,  y2, x3, y3, x4, y4);

           
    
        }
        public static void LongestLine(double x1, double y1, double x2, double y2,double x3 ,double y3 ,double x4 ,double y4)
        {
            double a1 = (x1 - x2);
            double b1 = (y1 - y2);
            double sum1 = a1*a1 + b1*b1;
            double a2 = x3 - x4;
            double b2 = y3 - y4;
            double sum2 = (a2*a2) + (b2*b2);
            if (sum1 >= sum2)
            {
                ClosestToCenter(x1, y1, x2, y2);
                
            }
            else
            {
                ClosestToCenter(x3, y3, x4, y4);
                
            }

        }
        public static void ClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double sum1 = Math.Abs(x1) + Math.Abs(y1);
            double sum2 = Math.Abs(x2) + Math.Abs(y2);
            if (sum1 <= sum2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }


    }
}
