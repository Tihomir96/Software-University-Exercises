using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Shoping_Spree
{
    public class Product
    {
        private decimal price;

        private string name;

        public Product(string name, decimal price)
        {
            this.Price = price;
            this.Name = name;
        }
        public string Name
        {
            get { return this.name; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.price = value;
            }
        }

    }
}
