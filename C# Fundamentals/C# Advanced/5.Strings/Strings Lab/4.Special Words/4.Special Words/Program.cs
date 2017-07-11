using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Special_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string,int>();
            var specWords = Console.ReadLine().Split(' ');
            for (int i = 0; i < specWords.Length; i++)
            {
                dict.Add(specWords[i],0);
            }
            var input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                {
                    dict[input[i]]++;
                }
            }
            foreach (var specWord in dict)
            {
                Console.WriteLine(specWord.Key +" - "+specWord.Value);
            }
        }
    }
}
