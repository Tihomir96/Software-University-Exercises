using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main()
        {

            var marathonDays = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var averageLapsPerRunner = Console.ReadLine();
            var lengthOfTrack = Console.ReadLine();
            var capacityOfTrackDay = int.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());


            decimal maxCapacityOftrack = capacityOfTrackDay * marathonDays;
            if (runners <= maxCapacityOftrack)
            {
                decimal totalKm = (runners * decimal.Parse(averageLapsPerRunner) * decimal.Parse(lengthOfTrack)) / 1000;

                decimal marathonMoney = totalKm * moneyPerKm;

                Console.WriteLine("Money raised: {0:f2}", marathonMoney);

            }
            else
            {
                decimal totalKm = (maxCapacityOftrack * decimal.Parse(averageLapsPerRunner) * decimal.Parse(lengthOfTrack)) / 1000;

                decimal marathonMoney = totalKm * moneyPerKm;

                Console.WriteLine("Money raised: {0:f2}", marathonMoney);
            }
        }
    }
}
