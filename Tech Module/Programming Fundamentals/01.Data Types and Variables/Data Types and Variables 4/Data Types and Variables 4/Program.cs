using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string numstring = Console.ReadLine();
            int num = Convert.ToInt32(numstring, 16);
            Console.WriteLine(num);
        }
    }
}
