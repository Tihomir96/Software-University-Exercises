using System;
using System.Collections.Generic;

namespace _4.Shoping_Spree
{
    public class Person
    {
        private string name;
        private List<Product> bag;

        public IList<Product> GetProducts()
        {
            return this.bag.AsReadOnly();
        }
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        private decimal money;

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public void BuyProduc(Product product)
        {
            if (this.Money < product.Price)
            {
                throw new Exception($"{this.Name} can't afford {product.Name}");
            }
            this.bag.Add(product);
            this.Money -= product.Price;
        }

        
    }
}
