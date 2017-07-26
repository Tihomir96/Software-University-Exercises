using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Wild_Farm.Animals;

namespace _3.Wild_Farm.Models.Animals
{
    public abstract class Mammal:Animal
    {
        public Mammal(string name, string type, double weight,string livingRegion) : base(name, type, weight)
        {
            this.LivingRegion = livingRegion;
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable")
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }
            base.Eat(food);
        }
        public override string ToString()
        {
            return $"{GetType().Name}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        protected string LivingRegion { get; set; }

    }
}
