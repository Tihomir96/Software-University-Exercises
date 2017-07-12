namespace _01.Count_Working_Days
{
    using System;
    using System.Linq;
    using System.Globalization;
    using System.Collections.Generic;

    public class CountWorkingDays
    {
        public static void Main()
        {
            var sDay = Console.ReadLine();

            var startDay = DateTime.ParseExact(
                sDay,
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture);
            var eDay = Console.ReadLine();

            var endDay = DateTime.ParseExact(
                eDay,
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture);


            int workingDays = 0;

            var holidays = new List<DateTime>();
            for(int year = startDay.Year; year <= endDay.Year; year++)
            {
                holidays.Add(new DateTime(year, 01, 01));
                holidays.Add(new DateTime(year, 03, 03));
                holidays.Add(new DateTime(year, 05, 01));
                holidays.Add(new DateTime(year, 05,06));
                holidays.Add(new DateTime(year, 05,24));
                holidays.Add(new DateTime(year, 09,06));
                holidays.Add(new DateTime(year, 09,22));
                holidays.Add(new DateTime(year, 11,01));
                holidays.Add(new DateTime(year, 12, 24));
                holidays.Add(new DateTime(year, 12, 25));
                holidays.Add(new DateTime(year, 12, 26));
                 
             
            }

            for (var currentDate = startDay; currentDate <= endDay; currentDate = currentDate.AddDays(1))
            {
                if (!(currentDate.DayOfWeek == DayOfWeek.Saturday ||
                    currentDate.DayOfWeek == DayOfWeek.Sunday ||
                    holidays.Contains(currentDate))
                    )
                {   
                    workingDays++;
                }
            }
            Console.WriteLine(workingDays);
        }
    }
}