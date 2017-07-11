using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main()
        {
            var beehives = Console.ReadLine().Split().Select(double.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(double.Parse).ToList();
            double hornetsPower = 0;
            if (hornets.Count > 0)
            {
                hornetsPower = hornets.Sum();

            }
            else
            {
                 hornetsPower = 0;
            }

            if(beehives.Count > 0)
            {

            for (int i = 0; i < beehives.Count; i++)
            {
               var bees = beehives[i];
                if (bees >= hornetsPower)
                {
                    hornets.Remove(hornets[0]);
                        if(hornets.Count == 0)
                        {
                            break;
                        }
                    beehives[i] = Math.Abs(beehives[i] - hornetsPower);
                    hornetsPower = hornets.Sum();

                }
                else
                {
                    beehives[i] = 0;
                }

            }
            var beeWinners = new List<double>();
            var hornetsWinners = new List<double>();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (beehives[i] > 0)
                {
                    beeWinners.Add(beehives[i]);
                }
            }

            for (int i = 0; i < hornets.Count; i++)
            {
                if (hornets[i] > 0)
                {
                    hornetsWinners.Add(hornets[i]);
                }
            }
            if (beeWinners.Count == 0)
            {
                Console.WriteLine($"{string.Join(" ", hornetsWinners)}");
            }
            else
            {

                Console.WriteLine($"{string.Join(" ", beeWinners)}");
            }
            }
            else
            {
                Console.WriteLine();
            }

        }
    }
}
