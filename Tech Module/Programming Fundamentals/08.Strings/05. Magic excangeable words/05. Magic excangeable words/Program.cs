using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_excangeable_words
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            string first = input[0];
            string second = input[1];

            int min = Math.Min(first.Length, second.Length);

            int firtsLen = first.ToCharArray().Distinct().Count();
            int secondLen = second.ToCharArray().Distinct().Count();

            if (firtsLen != secondLen)
            {
                Console.WriteLine("false");
                return;
            }

            else
            {
                for (int i = 1; i < min; i++)
                {
                    bool check1 = first[i - 1] == first[i];
                    bool check2 = second[i - 1] == second[i];

                    if (check1 != check2)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                Console.WriteLine("true");
            }

        }
        
      /*  public static bool ExchangableWords(string firstString, string secondString)
        {
            var dict = new Dictionary<char, char>();
            if (firstString.Length>=secondString(int i = 0; i < firstString.Length; i++)
                {
                    if (!dict.ContainsKey(firstString[i]))
                    {
                        dict.Add(firstString[i], secondString[i]);
                    }
                    else
                    {
                        
                            
                    }



                
            }
                }*/



        
    }
}
