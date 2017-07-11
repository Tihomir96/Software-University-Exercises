using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AcConsumption =1.6;
        private const double FuelLoss = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption,  double tankCapacity)
            : base(fuelQuantity, fuelConsumption + AcConsumption,tankCapacity)
        {            
        }        
        public override void Refuel(double liters)
        {
            base.Refuel(liters * FuelLoss);
        }
    }
}
