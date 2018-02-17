using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Mordor_s_cruelty_plan.Models
{
    public class Gandalf
    {
        private List<Food> foodsEatenByGandi;

        public Gandalf()
        {
            this.foodsEatenByGandi=new List<Food>();
        }

        
        public int GetHappinessPoints()
        {
            return foodsEatenByGandi.Sum(f => f.GetHapinnesPoints());
        }
        public void Eat(Food food)
        {
            this.foodsEatenByGandi.Add(food);
        }
    }
}
