using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Character_Multiplier
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstStr = input[0];
            var secondStr = input[1];
            int sum = 0;
            var maxLength = Math.Max(firstStr.Length, secondStr.Length);
            for (int i = 0; i < maxLength; i++)
            {
                if (firstStr.Length <= i )
                {
                    sum += (int)secondStr[i];
                }
                else if (secondStr.Length <= i)
                {
                    sum += (int) firstStr[i];
                }
                else
                {
                    sum += (int)(firstStr[i] * secondStr[i]);                    
                }
            }
            Console.WriteLine(sum);
        }
    }
}
