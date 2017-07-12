using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables_19
{
    class Program
    {
        static void Main(string[] args)
        {
            long pics = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            double goodPics =((double)pics * (double)filterFactor) / 100;
            long betterPics =(long) Math.Ceiling(goodPics);
            long totalTime = (pics * filterTime) + ((long)betterPics * uploadTime);

            TimeSpan timespan = TimeSpan.FromSeconds(totalTime);
            string time = timespan.ToString("d\\:hh\\:mm\\:ss");
            Console.WriteLine(time);
        }
    }
}
