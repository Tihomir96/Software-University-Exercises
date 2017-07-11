using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_String
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var output = Reverse(text);
            Console.WriteLine(output);
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    
}
