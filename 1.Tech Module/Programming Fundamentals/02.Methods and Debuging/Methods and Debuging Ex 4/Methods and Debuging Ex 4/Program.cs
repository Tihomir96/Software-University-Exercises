using System;

namespace Methods_and_Debuging_Ex_4
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            ReverseNum(number);
        }
        public static void ReverseNum (double number)
        {
            
            string num2 = number.ToString();
            for (int i = num2.Length - 1; i >= 0; i--)
            {
                Console.Write(num2[i]);

            }
            
        }
        

}
}
