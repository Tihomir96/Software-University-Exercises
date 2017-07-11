using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Customer
    {
        public String Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; } = new Dictionary<string, int>();

        public void AddOrder(string name, int quantity)
        {
            if (ShopList.ContainsKey(name))
            {
                ShopList[name] += quantity;
            }
            else
            {
                ShopList.Add(name, quantity);
            }
        }

        public decimal Bill ()
        {
            decimal result = 0;

            foreach (var item in ShopList)
            {
                string product = item.Key;
                int amount = item.Value;
                decimal value = Program.pricePerEntity[product] * amount;
                result += value;
            }
            
            return result;
        }
    }
}