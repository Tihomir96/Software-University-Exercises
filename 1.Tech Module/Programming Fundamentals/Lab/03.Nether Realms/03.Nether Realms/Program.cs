using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main()
        {
            string [] input = Console.ReadLine().Split(new[] { ' ', ',', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var dict = new Dictionary<string, DemonProp>();

            for (int i = 0; i < input.Length; i++)
            {
                var patternNum = @"([-+]?[0-9]*\.?[0-9]+)";
                var patternLetter = @"[A-Za-z]";
                var patternMultiplyDivide = @"\*|\/";
                var regexNum = new Regex(patternNum);


                var regexLetter = new Regex(patternLetter);
                var regexMath = new Regex(patternMultiplyDivide);

                long health = DemonHealth(regexLetter, input[i]);
                decimal damage = DemonDamage(regexNum, regexMath, input[i]);

                if (!dict.ContainsKey(input[i]))
                {
                    var demon = new DemonProp();
                    demon.Health = health;
                    demon.Damage = damage;
                    dict.Add(input[i], demon);
                }
            }
            foreach (var demon in dict.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{demon.Key} - {demon.Value.Health} health, {demon.Value.Damage:f2} damage");
            }
        }
        private static decimal DemonDamage(Regex regexNum, Regex regexMath, string input)
        {
            var matchesNum = regexNum.Matches(input.ToString());
            decimal sumDMG = 0;
            foreach (Match match in matchesNum)
            {
                var @num = decimal.Parse((match.Value));

                sumDMG += @num;
            }
            var matchesDivMul = regexMath.Matches(input.ToString());
            foreach(Match match in matchesDivMul)
            {
                if(match.ToString() == "/")
                {
                    sumDMG /= 2;
                }else
                {
                    sumDMG *= 2;
                }
            }
            return sumDMG;
        }

        private static long DemonHealth(Regex regexLetter, string input)
        {
            var matches =regexLetter.Matches(input);

            long sum = 0;
            foreach (Match match in matches)
            {
                var @char = match.Value[0];
                sum += (int)@char;

            }
            return sum;
        }
        class DemonProp
        {
            public long Health { get; set; }
            public decimal Damage { get; set; }
        }


    }
}
