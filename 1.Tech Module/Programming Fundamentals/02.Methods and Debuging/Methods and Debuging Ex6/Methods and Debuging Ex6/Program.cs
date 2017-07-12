using System;

namespace Methods_and_Debuging_Ex6
{
    class Program
    {
        static void Main()
        {
            ulong num = ulong.Parse(Console.ReadLine());
            Console.WriteLine( IsPrime(num));
        }
        public static bool IsPrime(ulong num)
        {
           
            if ((num & 1) == 0)
            {
                if (num == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            for (ulong i = 3; (i * i) <= num; i += 2)
            {
                if ((num % i) == 0)
                {
                    
                    return false;
                }
            }
            return num != 1;
        }
    }
}
 