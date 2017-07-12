using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            try
            {
                long longNum = long.Parse(num);
                Console.WriteLine("{0} can fit in:",num);
            }
            catch (Exception)
            {
            }
            try
            {
                sbyte sbyteNum = sbyte.Parse(num);
                Console.WriteLine("* sbyte");
            }
            catch (Exception)
            {
            }
            try
            {
                byte byteNum = byte.Parse(num);
                Console.WriteLine("* byte");

            }
            catch (Exception)
            {
            }
            try
            {
                short shortNum = short.Parse(num);
                Console.WriteLine("* short");
            }
            catch (Exception)
            {
            }
            try
            {
                ushort ushortNum = ushort.Parse(num);
                Console.WriteLine("* ushort");
            }
            catch (Exception)
            {
            }
            try
            {
                int intNum = int.Parse(num);
                Console.WriteLine("* int");
            }
            catch (Exception)
            {
            }
            try
            {
                uint uintNum = uint.Parse(num);
                Console.WriteLine("* uint");

            }
            catch (Exception)
            {
            }
            try
            {
                long longNum = long.Parse(num);
                Console.WriteLine("* long");
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't fit in any type", num);
            }
        }
    }
}
