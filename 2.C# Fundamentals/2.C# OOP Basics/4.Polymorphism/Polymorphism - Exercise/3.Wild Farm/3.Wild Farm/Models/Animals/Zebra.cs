
namespace _3.Wild_Farm.Models.Animals
{
    public class Zebra:Mammal
    {
        public Zebra(string name, string type, double weight, string livingRegion) : base(name, type, weight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return $"Zs";
        }
    }
}
