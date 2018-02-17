using System;
using _3.Wild_Farm.Animals;
using _3.Wild_Farm.Factories;

namespace _3.Wild_Farm
{
    public class Program
    {
        public static void Main()
        {
            string input = string.Empty;
            while ((input=Console.ReadLine())!="End")
            {
                var tokens = input.Split(new char[]{'\t','\n',' '}, StringSplitOptions.RemoveEmptyEntries);
                Animal animal = AnimalFactory.GetAnimal(tokens);
                var foodTokens = Console.ReadLine().Split(new char[] { '\t', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Food food =  FoodFactory.GetFood(foodTokens);
                
                Console.WriteLine(animal.MakeSound());
                try
                {
                    animal.Eat(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);                    
                }
                    Console.WriteLine(animal);
            }
        }
    }
}
