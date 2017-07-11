using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_and_Exceptions_Lab
{
    class Program
    {
        static void Main()
        {
            var words = File.ReadAllText("words.txt").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var text = File.ReadAllText("text.txt");

            var result = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {

            }
        }
    }
}
