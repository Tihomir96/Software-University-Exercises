using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5.Mordor_s_cruelty_plan.Factories;
using _5.Mordor_s_cruelty_plan.Models;

namespace _5.Mordor_s_cruelty_plan
{
    public class Program
    {
        public static void Main()
        {
            var foodFactory = new FoodFactory(); 
            var moodFactory = new MoodFactory();

            var inputFoods = Console.ReadLine()
                .Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            var gandi = new Gandalf();
            foreach (var foodstring in inputFoods)
            {
                var food = foodFactory.GetFood(foodstring);
                gandi.Eat(food);
            }
            var totalhappines = gandi.GetHappinessPoints();
            var mood = moodFactory.GetMood(totalhappines);
            Console.WriteLine(totalhappines);
            Console.WriteLine(mood);
        }
    }
}
