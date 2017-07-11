using System;

namespace _5.Pizza_Calories
{
    public class Topping
    {
        private string type;

        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" &&
                    value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }

        public double GetCalories()
        {
            return 2 * Weight *this.GetTypeMod();
        }


        private double GetTypeMod()
        {
            if (this.Type.ToLower() == "meat")
            {
                return 1.2;
            }
            else if (this.Type.ToLower() == "veggies")
            {
                return 0.8;
            }
            else if (this.Type.ToLower() == "cheese")
            {
                return 1.1;
            }
            else
            {
                return 0.9;
            }
        }

    }
}
