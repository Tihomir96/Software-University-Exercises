using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Population_Counter
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
           
            var dict = new Dictionary<string,Coutry>();
            while (input!="report")
            {
                var tokens = input.Split(new char[]{ '|' },StringSplitOptions.RemoveEmptyEntries);
                var city = tokens[0];
                var countryName = tokens[1];
                var population = int.Parse(tokens[2]);
                if (!dict.ContainsKey(countryName))
                {
                    var countryProp = new Coutry();
                    countryProp.Cities.Add(city, population);
                    dict.Add(countryName, countryProp);
                }
                else
                {
                    if (!dict[countryName].Cities.ContainsKey(city))
                    {
                        dict[countryName].Cities.Add(city, population);
                    }
                    else
                    {
                        dict[countryName].Cities[city] += population;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var coutry in dict.OrderByDescending(x=> x.Value.Cities.Values.Sum()))
            {
                Console.WriteLine($"{coutry.Key} (total population: {coutry.Value.Cities.Values.Sum()})");
                foreach (var city in coutry.Value.Cities.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
        class Coutry
        {
            public Dictionary<string, long> Cities { get; set; } = new Dictionary<string, long>();
        }
    }
}
