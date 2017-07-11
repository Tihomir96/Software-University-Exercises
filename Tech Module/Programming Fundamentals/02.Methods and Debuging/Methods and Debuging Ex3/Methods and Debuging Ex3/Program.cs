using System;

namespace Methods_and_Debuging_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            long lastDigit = SomeNumber(num);
            Console.WriteLine(Letter(lastDigit));
           
        }
        public static long SomeNumber(long num)
            {
            long lastNum = num % 10;
            
            return Math.Abs(lastNum);

            }
        public static string Letter (long lastNum)
        {
            
            if (lastNum == 0)
            {
                return "zero";
                
            }
            else if (lastNum == 1)
            {
                return "one";
            }
            else if (lastNum == 2)
            {
                return "two";
            }
            else if (lastNum == 3)
            {
                return "three";
            }
            else if (lastNum == 4)
            {
                return "four";
            }
            else if (lastNum == 5)
            {
                return "five";
            }
            else if (lastNum == 6)
            {
                return "six";
            }
            else if (lastNum == 7)
            {
                return "seven";
            }
            else if (lastNum == 8)
            {
                return "eight";
            }
            else if (lastNum == 9)
            {
                return "nine";
            }
            return "error";
        }

    }
}
