using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Users
    {
        public Dictionary<string, int> UserIp { get; set; } = new Dictionary<string, int>();

    }

    class Program
    {
        static void Main()
        {


            var dict = new Dictionary<string, Users>();

            var input = Console.ReadLine().Split(' ');
            Users user;

            while (input[0] != "end")
            {

                var userIp = UserProp(input[0]);
                var userMessage = UserProp(input[1]);
                var userName = UserProp(input[2]);
                if (!dict.ContainsKey(userName))
                {
                    user = new Users();
                    user.UserIp = new Dictionary<string, int>();
                    user.UserIp.Add(userIp, 1);
                    dict.Add(userName, user);
                }
                else
                {
                    var userObject = dict[userName];

                    if (userObject.UserIp.ContainsKey(userIp))
                    {
                        userObject.UserIp[userIp]++;
                    }
                    else
                    {
                        dict[userName].UserIp.Add(userIp, 1);
                    }
                }
                input = Console.ReadLine().Split(' ');
            }
            foreach (var kvp in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key + ": ");
                string s = string.Join(", ", kvp.Value.UserIp.Select(x => x.Key + " => " + x.Value).ToArray());
                Console.WriteLine($"{s}.");
            }
        }
        private static string UserProp(string input)
        {
            var userProp = input.Substring(input.IndexOf("=")).Trim('=');
            return userProp;
        }
        class Users
        {
            public Dictionary<string, int> UserIp { get; set; } = new Dictionary<string, int>();

        }
    }
}
