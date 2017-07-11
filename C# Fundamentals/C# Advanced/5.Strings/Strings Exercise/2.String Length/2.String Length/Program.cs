using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            if (input.Length < 20)
            {
                var charList = new List<char>();
                for (int i = 0; i < input.Length; i++)
                {
                    charList.Add(input[i]);
                }
                for (int i = input.Length; i < 20; i++)
                {
                    charList.Add('*');
                }
                Console.WriteLine(string.Join("",charList));
            }
            else
            {
                var substring = input.ToString().Substring(0, 20);
                Console.WriteLine(substring);
            }
            
        }
    }
}
