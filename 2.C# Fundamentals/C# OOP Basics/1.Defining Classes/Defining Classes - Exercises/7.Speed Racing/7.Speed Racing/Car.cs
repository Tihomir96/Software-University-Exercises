using System;
using System.Collections.Specialized;
using System.Net.Configuration;

namespace _7.Speed_Racing
{
    class Car
    {
        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumption;
        

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public decimal FuelAmount {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public decimal FuelConsumption {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        private decimal distance;

        public decimal Distance
        {
            get { return this.distance; }
            set { this.distance = value; }
        }

        public void CarTraveling(decimal km)
        {

            if (this.FuelAmount / this.FuelConsumption >= km)
            {
                this.Distance += km;
                this.FuelAmount -= this.FuelConsumption * km;

            }
            else
            {                
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }

    }
}
