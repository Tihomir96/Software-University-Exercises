using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Thea_the_Photographer
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            decimal filterFactor = decimal.Parse(Console.ReadLine());
            var uploadTime = long.Parse(Console.ReadLine());

            var filteredPictures = Math.Ceiling((n * filterFactor) / 100);
            var totalTime = (n * filterTime) + (filteredPictures *uploadTime);

            TimeSpan timespan = TimeSpan.FromSeconds((double)totalTime);
            if(timespan.Days >= 10)
            {
                string time = timespan.ToString("dd\\:hh\\:mm\\:ss");
                Console.WriteLine(time);
            }
            else
            {
            string time = timespan.ToString("d\\:hh\\:mm\\:ss");
            Console.WriteLine(time);
           

            }


        }
    }
}
