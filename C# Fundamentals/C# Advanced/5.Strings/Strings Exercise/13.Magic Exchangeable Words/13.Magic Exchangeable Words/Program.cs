namespace _13.Magic_Exchangeable_Words
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
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
    }
}
