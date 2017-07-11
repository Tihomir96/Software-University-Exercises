using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.Little_John
{
    class Program
    {

        static void Main()
        {

            var sb = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                sb.Append(Console.ReadLine()+" ");
            }
           
             var regex = new Regex(@"(?<smallArrow>>----->)|(?<bigArrow>>>>----->>)|(?<mediumArrow>>>----->)");
           
            var mathes = regex.Matches(sb.ToString());
            var sArrow = 0;
            int mArrow = 0;
            int lArrow = 0;
            foreach (Match match in mathes)
            {
                var matches = match;
                sArrow += match.Groups["smallArrow"].Length /7;
                mArrow += match.Groups["mediumArrow"].Length / 8;
                lArrow += match.Groups["bigArrow"].Length / 10;
            }
            var number = sArrow.ToString() + mArrow.ToString() + lArrow.ToString();
            var toBinary = Convert.ToString(int.Parse(number), 2);            
            Console.WriteLine(Convert.ToInt32((toBinary + Reverse(toBinary)), 2));
           
        }
        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

    }

}
