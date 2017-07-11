using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.Valid_usernames
{
    class Program
    {
        static void Main(string[] args)
        {

            var validUsernames=Console.ReadLine().Split(new[] {'/', '\\', '(', ')', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Where(u => Regex.IsMatch(u, @"\b([a-zA-Z])([\w]){2,24}\b")).ToArray();

            int sum = 0;
            var firstBest = string.Empty;
            var secondBest = string.Empty;
            for (int i = 0; i < validUsernames.Length-1; i++)
            {
                string firstUser = validUsernames[i];
                var secondUser = validUsernames[i + 1];
                int currentLength = firstUser.Length + secondUser.Length;

                if (currentLength > sum)
                {
                    sum = currentLength;
                    firstBest =firstUser;
                    secondBest= secondUser;
                }
            }
            Console.WriteLine(firstBest);
            Console.WriteLine(secondBest);
        }
    }
}
