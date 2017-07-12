using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.Fix_Emails
{
    public class FixEmails
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            var emails = new Dictionary<string, string>();
            while (name != "stop")
            {
                string email = Console.ReadLine();
                bool uk = email.EndsWith("uk");
                bool us = email.EndsWith("us");
                if (!emails.ContainsKey(name))
                {
                    if (us || uk)
                    {
                        //emails.Remove(name);
                    }
                    else
                    {
                        emails.Add(name, email);

                    }
                }
                name = Console.ReadLine();
            }
            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
