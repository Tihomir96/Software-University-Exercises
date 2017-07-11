using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool d = Convert.ToBoolean(s);
            if (d == true)
            {
                Console.WriteLine("Yes");
            
            }else
            {
                Console.WriteLine("No");
            }
            

        }
    }
}
