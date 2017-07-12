using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main()
        {
            var ivanchosMoney = double.Parse(Console.ReadLine());
            var guests = double.Parse(Console.ReadLine());
            var bananas = double.Parse(Console.ReadLine()) * 2;
            var eggs = double.Parse(Console.ReadLine())* 4 ;
            var berries = double.Parse(Console.ReadLine()) * 0.2;

            var sets = Math.Ceiling(guests / 6);

            double total = (sets * bananas) + (sets * eggs) + (sets * berries);

            if (ivanchosMoney >= total)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv. ",total);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",(total-ivanchosMoney));
            }
        }
    }
}
    