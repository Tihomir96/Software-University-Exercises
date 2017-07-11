using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Ashes_of_Roses
{

    class Program
    {
        class Region
        {
            public Dictionary<string, long> flowers { get; set; } = new Dictionary<string, long>();
        }
        static void Main()
        {
            var input = Console.ReadLine();
            Region region;
            var dict = new Dictionary<string, Region>();
            var regex = new Regex(@"Grow\s<(?<region>[A-Z][a-z]+)>\s<(?<color>[A-Za-z0-9]+)>\s(?<count>\d+)");
                
            while (input != "Icarus, Ignite!")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    var place = match.Groups["region"].Value;
                    var colorName = match.Groups["color"].Value;
                    long count = long.Parse(match.Groups["count"].Value);
                    if (!dict.ContainsKey(place))
                    {
                        region = new Region();
                        region.flowers.Add(colorName, count);
                        dict.Add(place, region);
                    }
                    else
                    {
                        if (dict[place].flowers.ContainsKey(colorName))
                        {
                            dict[place].flowers[colorName] += count;
                        }
                        else
                        {
                            dict[place].flowers.Add(colorName,count);
                        }
                    }
                }
                else
                {
                }

                input = Console.ReadLine();
            }
            var orderedDict = dict.OrderByDescending(x => x.Value.flowers.Values.Sum()).ThenBy(x => x.Key);
            foreach (var flowersRegion in orderedDict)
            {
                Console.WriteLine(flowersRegion.Key);
                foreach (var flowerinfo in flowersRegion.Value.flowers.OrderBy(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"*--{flowerinfo.Key} | {flowerinfo.Value}");   
                }
            }
        }
    }
}
