using System;
using System.Globalization;

namespace _05._2.Date_Modifier
{
    public class DateModifier
    {
        public double Difference(string firstDate, string secDate)
        {
            var first = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var sec = DateTime.ParseExact(secDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            return (first - sec).TotalDays;
        }

    }
}
