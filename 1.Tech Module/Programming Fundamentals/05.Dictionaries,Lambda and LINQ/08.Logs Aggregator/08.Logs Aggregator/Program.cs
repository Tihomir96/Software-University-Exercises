using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main()
        {
            int logs = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, IpDuration>();
            for (int i = 0; i < logs; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var ip = input[0];
                var user = input[1];
                var duration = input[2];

                if (!dict.ContainsKey(user))
                {
                    var ipAndDuration = new IpDuration();
                    
                    ipAndDuration.IP.Add(ip);
                    ipAndDuration.DurationSeconds = int.Parse(duration);
                    dict.Add(user, ipAndDuration);
                }
                else
                {
                    dict[user].DurationSeconds += int.Parse(duration);
                    if (dict[user].IP.Contains(ip))
                    {
                        continue;
                    }else
                    {

                    dict[user].IP.Add(ip);
                    }
                }

            }
            var dict1 = dict.OrderBy(x => x.Key);
            foreach (var kvp in dict1)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.DurationSeconds} [{string.Join(", ",kvp.Value.IP.OrderBy(x => x))}]");
            }
        }
    class IpDuration
    {
        public List<string> IP { get; set; } = new List<string>();
        public int DurationSeconds { get; set; }
    }
    }
}