
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var cars = new List<Car>();
        for (int i = 0; i < lines; i++)
        {
            var carInfo = Console.ReadLine().Split();
            var car = new Car(carInfo[0],double.Parse(carInfo[1]),double.Parse(carInfo[2]));
            cars.Add(car);
        }
        string[] input = Console.ReadLine().Split();
        while (input[0]!="End")
        {
            try
            {
                cars.Where(x => x.Model == input[1].Trim()).FirstOrDefault().Drive(int.Parse(input[2]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            input = Console.ReadLine().Split();
        }
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTravelled}");
        }
    }
}

