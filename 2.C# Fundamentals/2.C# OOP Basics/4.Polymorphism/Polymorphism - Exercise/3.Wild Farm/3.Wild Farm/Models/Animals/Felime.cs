using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Wild_Farm.Models.Animals
{
    public abstract class Felime:Mammal
    {
        public Felime(string name, string type, double weight,string livingRegion) : base(name, type, weight,livingRegion)
        {
        }
        

    }
}
