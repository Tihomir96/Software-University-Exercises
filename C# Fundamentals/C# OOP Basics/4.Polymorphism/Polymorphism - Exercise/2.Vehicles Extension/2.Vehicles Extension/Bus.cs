using System;

namespace Vehicles
{
    public class Bus: Vehicle
    {
        private const double AcConsumption = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override bool Drive(double distance, bool isAcOn)
        {
            double reqFuel;
            if (isAcOn)
            {
                reqFuel = distance * (this.FuelConsumption + AcConsumption);
            }
            else
            {
                reqFuel = distance * this.FuelConsumption;
            }
            if (reqFuel <= this.FuelQuantity)
            {
                return true;
            }
            return false;
        }
        protected override double FuelQuantity
        {
            set
            {
                if (value + this.FuelQuantity > this.TankCapacity)
                {
                    throw  new ArgumentException("Cannot fit fuel in tank");
                }
                base.FuelQuantity = value;
            }
        }
       
    }
}
