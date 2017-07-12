using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Shoping_Spree
{
    public class Program
    {
        public static void Main()
        {
            var peoplesList = new List<Person>();
            var productsList = new List<Product>();
            var peoples = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var products = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                foreach (var people in peoples)
                {
                    var personInfo = people.Split('=');
                    var person = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                    peoplesList.Add(person);
                }

                foreach (var productInfo in products)
                {
                    var productTokens = productInfo.Split('=');
                    var product = new Product(productTokens[0], decimal.Parse(productTokens[1]));
                    productsList.Add(product);
                }
                string purchase;
                while ((purchase=Console.ReadLine())!="END")
                {
                    var tokens = purchase.Split();
                    var buyer = peoplesList.FirstOrDefault(x => x.Name == tokens[0]);
                    var boughtProduct = productsList.FirstOrDefault(x => x.Name == tokens[1]);
                    try
                    {
                        buyer.BuyProduc(boughtProduct);
                        Console.WriteLine($"{buyer.Name} bought {boughtProduct.Name}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                foreach (var person in peoplesList)
                {
                    var boughtProducts = person.GetProducts();
                    
                    var result = boughtProducts.Any()
                        ? string.Join(", ", boughtProducts.Select(p => p.Name).ToList())
                        : "Nothing bought";
                    Console.WriteLine($"{person.Name} - {result}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
