using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Wild_Farm.Models.Foods;

namespace _3.Wild_Farm.Factories
{
    class FoodFactory
    {
        public static Food GetFood(string[]tokens)
        {
            var foodType = tokens[0];
            var foodQuantity = int.Parse(tokens[1]);

            if (foodType == "Meat")
            {
                return new Meat(foodQuantity);
            }
            return new Vegetable(foodQuantity);
        }
    }
}
