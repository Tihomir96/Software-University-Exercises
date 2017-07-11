using System;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AcConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption+AcConsumption,tankCapacity)
        {           
        }
        protected override double FuelQuantity
        {
            set
            {
                if (value + this.FuelQuantity > this.TankCapacity)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }
                base.FuelQuantity = value;
            }
        }

    }
}
