using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string toHex = Convert.ToString(num, 16);
            string toBinary = Convert.ToString(num, 2);
            
            Console.WriteLine("{0}\n{1}",toHex.ToUpper(),toBinary);
        }
    }
}
