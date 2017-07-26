using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _5.Border_Control.Core
{
    public class Engine
    {
        public void FoodShortage()
        {
            var citizens = new List<Citizen>();
            var rebels = new List<Rebel>();
            var numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine().Split();
                if (input.Length == 4)
                {
                    var citizen = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                    citizens.Add(citizen);
                }
                else
                {
                    var rebel = new Rebel(input[0],int.Parse(input[1]));
                    rebels.Add(rebel);
                }
            }
            var names = string.Empty;
            while ((names=Console.ReadLine())!="End")
            {
                foreach (var rebel in rebels)
                {
                    if (rebel.Name == names)
                    {
                        rebel.BuyFood();
                    }                    
                }
                foreach (var citizen in citizens)
                {
                    if (citizen.Name == names)
                    {
                        citizen.BuyFood();
                    }
                }
            }
           
            var cityzen = new Citizen();
            var rebl = new Rebel();
            Console.WriteLine(cityzen.Food + rebl.Food);
        }
        public void BirthdayCelebration()
        {
            string input = string.Empty;
            var citizens = new List<Citizen>();
            var pets = new List<Pet>();
            while ((input = Console.ReadLine()) != "End")
            {
                var inputTokens = input.Split();
                if (inputTokens[0] == "Citizen")
                {
                    var citizen = new Citizen(inputTokens[1], int.Parse(inputTokens[2]), inputTokens[3], inputTokens[4]);
                    citizens.Add(citizen);
                }
                else if (inputTokens[0] == "Pet")
                {
                    var pet = new Pet(inputTokens[1], inputTokens[2]);
                    pets.Add(pet);
                }
                else
                {
                    //Nothing happens here
                }

            }

            var birthYear = Console.ReadLine();
            foreach (var citizen in citizens.Where(x => x.BirthDate.EndsWith(birthYear)))
            {
                Console.WriteLine(citizen.BirthDate);
            }
            foreach (var pet in pets.Where(x => x.BirthDate.EndsWith(birthYear)))
            {
                Console.WriteLine(pet.BirthDate);
            }
        }
    }
}
