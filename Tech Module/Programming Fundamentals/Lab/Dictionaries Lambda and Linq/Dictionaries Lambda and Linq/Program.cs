using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_Lambda_and_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            var words = Console.ReadLine().ToLower().Split(' ');
            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }
            var print = new List<string>();
            foreach (var item in result)
            {
                if(item.Value %2 != 0)
                {
                    print.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ",print));
        }
    }
}
