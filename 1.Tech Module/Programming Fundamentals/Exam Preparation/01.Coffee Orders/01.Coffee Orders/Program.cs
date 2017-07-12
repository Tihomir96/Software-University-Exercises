using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _01.Coffee_Orders
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var orderDate = new DateTime();
            decimal total = 0;

            for (int i = 0; i < n; i++)
            {

                decimal price = decimal.Parse(Console.ReadLine());
                var date = Console.ReadLine();
                orderDate = DateTime.ParseExact(date, "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal capsules = decimal.Parse(Console.ReadLine());
                decimal daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal priceForCoffee = ((daysInMonth * capsules) * price);
                
                Console.WriteLine("The price for the coffee is: ${0:f2}",priceForCoffee);
                total += priceForCoffee;
                
            }
            Console.WriteLine("Total: ${0:f2}",total);
            
        }
    }
}
