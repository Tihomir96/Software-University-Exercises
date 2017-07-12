using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    public class Program
    {
        public static void Main()
        {

            var input = Console.ReadLine().Split(' ');
            var input1 = input[0];
            var input2 = input[1];

            int sum = 0;
            var charArr1 = input1.ToCharArray();
            var charArr2 = input2.ToCharArray();
        
            if (input1.Length >= input2.Length)
            {
                for (int i = 0; i < input2.Length; i++)
                {
                    sum += charArr1[i] * charArr2[i];
                    
                }
                for (int i = input2.Length; i < input1.Length; i++)
                {
                    sum += charArr1[i];
                }
           
            }
            else
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    sum += charArr1[i] * charArr2[i];

                }
                for (int i = input1.Length; i < input2.Length; i++)
                {
                    sum += charArr2[i];
                }

            }
            Console.WriteLine(sum);


        }

    }
}
