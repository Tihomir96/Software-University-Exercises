using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Softuni_Karaoke
{
    class Program
    {
        static void Main()
        {
            char[] separator = { ',', ' '};
           

            string[] participants = Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);
            string[] song = Console.ReadLine().Split(new string[] { ", "  },StringSplitOptions.RemoveEmptyEntries);
            var parSongAward = Console.ReadLine();
            var dict = new Dictionary<string, List<string>>();
            while (parSongAward != "dawn")
            {

                var parSongAward1 = parSongAward.Split(new string[] { ", "},StringSplitOptions.RemoveEmptyEntries);
                if (participants.Contains(parSongAward1[0])&& song.Contains(parSongAward1[1]))
                {
                    if (!dict.ContainsKey(parSongAward1[0]))
                    {
                        var awardsList = new List<string>();
                        awardsList.Add(parSongAward1[2]);
                        dict.Add(parSongAward1[0], awardsList);
                    }else
                    {
                        if (!dict[parSongAward1[0]].Contains(parSongAward1[2]))
                        {
                        dict[parSongAward1[0]].Add(parSongAward1[2]);

                        }
                    }
                }

                parSongAward = Console.ReadLine();
            }
            var dict1 = dict.OrderByDescending(c => c.Value.Count);
                if (dict1.Count()==0)
                {
                    Console.WriteLine("No awards");
                }
            foreach (var item in dict1)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                foreach (var award in item.Value.OrderBy(n=>n))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
