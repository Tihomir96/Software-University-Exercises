using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd_Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string[] firstArr = first.Split(' ');
            string[] secondArr = second.Split(' ');


            int resultLeft = LeftSequenceLentgh(firstArr, secondArr);
            int resultRight = RightSequenceLentgh(firstArr, secondArr);

            if (resultLeft > resultRight)
            {
                Console.WriteLine(resultLeft);
            }
            else if (resultLeft <= resultRight)
            {
                Console.WriteLine(resultRight);
            }


        }
        public static int LeftSequenceLentgh(string[] first, string[] second)
        {
            int result = 0;
            for (int i = 0; i < first.Length && i < second.Length; i++)
            {
                if (first[i] == second[i])
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
            return result;

        }
        public static int RightSequenceLentgh(string[] first, string[] second)
        {
            int n = first.Length;
            int m = second.Length;
            int resultRight = 0;

            for (int i = 1; i <= first.Length && i <= second.Length; i++)
            {
                if (first[n - i] == second[m - i])
                {
                    resultRight++;
                }
                else
                {
                    break;
                }


            }
            return resultRight;


        }
    }
}
