using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Srbsko_UNLEASHED
{
    class Program
    {
        static void Main()
        {
            var venues =new Dictionary<string,Dictionary<string,int>>();
            var line =Console.ReadLine();

            while (line != "End")
            {
                var venueTokens = line.Split(new[] {" @"}, StringSplitOptions.RemoveEmptyEntries);
                if (!InputIsValid(venueTokens))
                {
                    line = Console.ReadLine();
                    continue;
                }
                var singer = venueTokens[0];
                var venueAndTickets = venueTokens[1].Split();

                var ticketPrice = 0;
                var ticketCount = 0;

                try
                {
                    ticketPrice = int.Parse(venueAndTickets[venueAndTickets.Length-2]);
                    ticketCount = int.Parse(venueAndTickets[venueAndTickets.Length-1]);
                }
                catch (Exception e )
                {
                    line = Console.ReadLine();
                    continue;
                }

                var venue = new StringBuilder();

                for (int i = 0; i < venueAndTickets.Length-2; i++)
                {
                    venue.Append(venueAndTickets[i]+ " ");
                }
                if (venues.ContainsKey(venue.ToString()))
                {

                    if (venues[venue.ToString()].ContainsKey(singer))
                    {
                        venues[venue.ToString()][singer] += ticketPrice * ticketCount;
                    }
                    else
                    {

                        venues[venue.ToString()].Add(singer, ticketPrice * ticketCount);
                    }

                }
                else
                {
                        venues[venue.ToString()] = (new Dictionary<string, int>() { { singer, ticketPrice * ticketCount } });                        
                    
                }
                line = Console.ReadLine();
            }
            foreach (var venue in venues)
            {
                Console.WriteLine($"{venue.Key}");
                foreach (var singer in venue.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
                
            }
        }
        private static bool InputIsValid(string[] venueTokens)
        {
            if (venueTokens.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
