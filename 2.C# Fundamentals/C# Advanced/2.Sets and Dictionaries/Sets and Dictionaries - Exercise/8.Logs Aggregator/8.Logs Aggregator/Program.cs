using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UserLogs
{
    public HashSet<string> UserIp { get; set; }
    public int Duration { get; set; }

}

namespace _8.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            UserLogs user;
            var dict = new Dictionary<string, UserLogs>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[1];
                var ip = input[0];
                var duration = int.Parse(input[2]);
                if (!dict.ContainsKey(name))
                {
                    user = new UserLogs();
                    user.UserIp = new HashSet<string>();
                    user.UserIp.Add(ip);
                    user.Duration = duration;
                    dict.Add(name, user);
                }
                else if (dict.ContainsKey(name))
                {
                    dict[name].UserIp.Add(ip);
                    dict[name].Duration += duration;
                }


            }

            foreach (var userip in dict.OrderBy(d => d.Value.Duration))
            {
                Console.WriteLine($"{userip.Key}: {userip.Value.Duration} [{string.Join(", ", userip.Value.UserIp.OrderBy(x => x))}]");
            }
        }
    }
}

