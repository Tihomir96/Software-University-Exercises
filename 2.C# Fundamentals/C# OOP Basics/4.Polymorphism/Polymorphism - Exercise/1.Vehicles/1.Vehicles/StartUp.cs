using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            var TruckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(TruckInfo[1]), double.Parse(TruckInfo[2]));
            int numOfComm = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfComm; i++)
            {
                var input = Console.ReadLine().Split();
                if (input[1] == "Car")
                {
                    driveOrRefuel(input[0], input[2], car);
                }
                else
                {
                    driveOrRefuel(input[0], input[2], truck);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void driveOrRefuel(string action, string litersOrDistance, Vehicle vehicle)
        {
            if (action == "Drive")
            {
                Console.WriteLine(vehicle.Drive(double.Parse(litersOrDistance)));
            }
            else
            {
                vehicle.Refuel(double.Parse(litersOrDistance));
            }
        }
    }
}
