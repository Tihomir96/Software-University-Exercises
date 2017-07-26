using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Wild_Farm.Models.Animals
{
    public class Tiger:Felime
    {
        public Tiger(string name, string type, double weight, string livingRegion) : base(name, type, weight, livingRegion)
        {
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
                
            }
        }
        public override string MakeSound()
        {
            return $"ROAAR!!!";
        }
    }
}
