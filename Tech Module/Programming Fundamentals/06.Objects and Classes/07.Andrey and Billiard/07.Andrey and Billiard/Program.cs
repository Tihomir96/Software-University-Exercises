using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        public static Dictionary<string,decimal> pricePerEntity = new Dictionary<string, decimal>();
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                var inDecimal = decimal.Parse(input[1]);
                
                if (pricePerEntity.ContainsKey(input[0]))
                {
                    pricePerEntity[input[0]] = inDecimal;
                }else
                {
                     pricePerEntity.Add(input[0],inDecimal);
                }
                
            }

            var secondInput = Console.ReadLine().Split('-', ',');
            var validCustomers = new Dictionary<string, Customer>();
            while (secondInput[0] != "end of clients")
            {
                string name = secondInput[0];
                string product = secondInput[1];
                int quantity = int.Parse(secondInput[2]);

                if (pricePerEntity.ContainsKey(secondInput[1]))
                {
                    var customer = new Customer();
                    if (validCustomers.ContainsKey(name))
                    {
                        customer = validCustomers[name];
                    } else
                    {
                        customer.Name = name;
                        validCustomers.Add(name, customer);
                    }
                    customer.AddOrder(product, quantity);
                }
                
                secondInput = Console.ReadLine().Split('-', ',');
            }

            decimal sum = 0;
            var sortedCustomers = validCustomers.OrderBy(customer => customer.Value.Name);
            

            foreach (var client in sortedCustomers)
            {
            
                Console.WriteLine(client.Value.Name);

                foreach (var item in client.Value.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {client.Value.Bill():f2}");

                sum += client.Value.Bill();
                
            }
            Console.WriteLine($"Total bill: {sum:f2}");
        }
    }
}
