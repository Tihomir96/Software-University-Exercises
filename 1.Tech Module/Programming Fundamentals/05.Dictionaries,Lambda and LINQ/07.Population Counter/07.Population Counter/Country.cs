using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
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
}

