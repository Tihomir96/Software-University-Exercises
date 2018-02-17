
using System;

namespace _3.Wild_Farm.Models.Animals
{
    public class Mouse:Mammal
    {
        public Mouse(string name, string type, double weight,string livingRegion) : base(name, type, weight,livingRegion)
        {
        }

       
        public override string MakeSound()
        {
            return $"SQUEEEAAAK!";
        }
    }
}
