using System;
namespace Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            
            var carInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]),double.Parse(carInfo[3]));
            var truckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]),double.Parse(truckInfo[3]));
            var busInfo = Console.ReadLine().Split();
            Vehicle bus = new Bus(double.Parse(busInfo[1]),double.Parse(busInfo[2]),double.Parse(busInfo[3]));
            int numOfComm = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfComm; i++)
            {
                try
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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);                    
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void driveOrRefuel(string action, string litersOrDistance, Vehicle vehicle)
        {
            try
            {

           
            if (action == "Drive")
            {
                Console.WriteLine(vehicle.TryTravelDistance(double.Parse(litersOrDistance)));
            }
            else if(action=="Refuel")
            {
                
                vehicle.Refuel(double.Parse(litersOrDistance));
            }
            else if (action == "DriveEmpty")
            {
                vehicle.TryTravelDistance(double.Parse(litersOrDistance), false);
            }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
