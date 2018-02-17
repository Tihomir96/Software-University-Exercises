
using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> topping;
        private int numberOfTopping;

        public Pizza(string name, Dough dough,  int numberOfTopping)
        {
            this.Name = name;
            this.dough = dough;
            this.topping = new List<Topping>();
            this.NumberOfToppings = numberOfTopping;
        }
        public int NumberOfToppings
        {
            get { return this.numberOfTopping; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this.numberOfTopping = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.topping.Add(topping);
        }

        public double GetCalories()
        {
            return this.dough.GetCalories() + this.topping.Sum(t => t.GetCalories());
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        

    }
}
