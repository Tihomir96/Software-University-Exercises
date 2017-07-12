using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Speed_Racing
{
    public class Program
    {
        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            Car car;
            string input = String.Empty;
            var listCars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                input = Console.ReadLine();
                var tokens = input.Split();
                var carModel = tokens[0];
                var carFuelAmount = decimal.Parse(tokens[1]);
                var carFuelConsumption = decimal.Parse(tokens[2]);
                car = new Car();
                car.Model = carModel;
                car.FuelAmount = carFuelAmount;
                car.FuelConsumption = carFuelConsumption;
                listCars.Add(car);
            }

            while ((input=Console.ReadLine())!="End")
            {
                var tokens = input.Split();
                var model = tokens[1];
                var distance = decimal.Parse(tokens[2]);
                listCars.Where(x=> x.Model==model).FirstOrDefault().CarTraveling(distance);
            }
            foreach (var modelCar in listCars)
            {
                Console.WriteLine($"{modelCar.Model} {modelCar.FuelAmount:F2} {modelCar.Distance:F0}");
            }
        }
    }
}
