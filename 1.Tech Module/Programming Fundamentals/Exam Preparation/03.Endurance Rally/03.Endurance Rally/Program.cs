using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main()
        {
            var drivers = Console.ReadLine().Split(' ').ToArray();
            var track = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray() ;

            foreach (var driver in drivers)
            {
                driver.ToCharArray();
                double fuel = driver[0];
            for (int i = 0; i < track.Length; i++)
            {

                    var currentZoneFuel = track[i];
                    if (checkpoints.Contains(i))
                    {
                        fuel += currentZoneFuel;

                    }
                    else
                    {
                        fuel -= currentZoneFuel;
                        if(fuel <= 0)
                        {
                            Console.WriteLine($"{driver} - reached {i}");
                            break;
                        }
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }


            }

        }
    }
}
