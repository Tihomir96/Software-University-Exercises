using System;

namespace _3.Ferrari
{
    public class Ferrari:ICar
    {
        private const string model = "488-Spider";
        public const string Model = model;
        public string Driver { get; }
        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }

        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public override string ToString()
        {
            return $"{Model}/{this.Brakes()}/{this.Gas()}/{this.Driver}";
        }
    }
}
