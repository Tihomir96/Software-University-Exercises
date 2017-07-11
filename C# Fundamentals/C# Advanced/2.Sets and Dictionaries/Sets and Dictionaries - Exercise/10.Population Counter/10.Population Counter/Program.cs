using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        class Country
        {
            public string CountryName { get; set; }
            public List<City> Cities { get; set; } = new List<City>();
            public ulong Population { get; set; } = 0;

            public void AddCity(string name, int population)
            {
                City city = new City();
                city.CityName = name;
                city.Population = population;
                Cities.Add(city);

                Population += (ulong)population;
            }
        }
        class City
        {
            public string CityName { get; set; }
            public int Population { get; set; }

        }
        static void Main()
        {
            var input = Console.ReadLine().Split('|');
            var dict = new Dictionary<string, Country>();
            while (input[0] != "report")
            {
                string cityName = input[0];
                string country = input[1];
                string population = input[2];
                if (!dict.ContainsKey(country))
                {
                    int cityPopulation = int.Parse(population);
                    Country countryObject = new Country();
                    countryObject.AddCity(cityName, cityPopulation);

                    dict.Add(country, countryObject);
                }
                else
                {
                    Country countryObject = dict[country];
                    int cityPopulation = int.Parse(population);
                    countryObject.AddCity(cityName, cityPopulation);
                }

                input = Console.ReadLine().Split('|');
            }

            foreach (KeyValuePair<string, Country> country in dict.OrderByDescending(p => p.Value.Population))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Population})");
                foreach (City city in country.Value.Cities.OrderByDescending(p => p.Population))
                {
                    Console.WriteLine($"=>{city.CityName}: {city.Population}");
                }
            }

        }
    }
}
