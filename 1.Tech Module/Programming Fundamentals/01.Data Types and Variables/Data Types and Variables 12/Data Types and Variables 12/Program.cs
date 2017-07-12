using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = (width + height) * 2;
            double area = width * height;
            double diagonal = Math.Sqrt((width * width)+(height*height));
            Console.WriteLine("{0}\n{1}\n{2}", perimeter, area, diagonal);

        }
    }
}
