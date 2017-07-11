using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr1 = Console.ReadLine();
            string arr2 = Console.ReadLine();

            string[] firstArray = arr1.Split(' ');
            string[] secondArray = arr2.Split(' ');

            bool firstisBigger = true;
            bool areEqual = true;

            for (int i = 0; i < firstArray.Length && i < secondArray.Length; i++)
            {
                
                if (firstArray[i].CompareTo(secondArray[i]) == 0)
                {
                    continue;
                }
                else if (firstArray[i].CompareTo(secondArray[i]) < 0)
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                    return;
                } else
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                    return;
                }
            }
            if (firstArray.Length >= secondArray.Length)
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));

            }
            else
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
        }
    }
}
