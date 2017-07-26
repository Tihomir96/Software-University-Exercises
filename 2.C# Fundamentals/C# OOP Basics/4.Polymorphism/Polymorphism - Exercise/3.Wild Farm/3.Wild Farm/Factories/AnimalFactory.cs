using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Wild_Farm.Animals;
using _3.Wild_Farm.Models.Animals;

namespace _3.Wild_Farm.Factories
{
    public class AnimalFactory
    {
        public static Animal GetAnimal(string[] tokens)
        {
            var animalType = tokens[0];

            switch (animalType)
            {
                case"Mouse":
                    return new Mouse(tokens[1],animalType,double.Parse(tokens[2]),tokens[3]);
                case "Zebra":
                    return new Zebra(tokens[1], animalType, double.Parse(tokens[2]), tokens[3]);
                case "Cat":
                    return new Cat(tokens[1], animalType, double.Parse(tokens[2]), tokens[3],tokens[4]);
                case "Tiger":
                    return new Tiger(tokens[1], animalType, double.Parse(tokens[2]), tokens[3]);
                default:
                    return null;
            }
        }
    }
}
