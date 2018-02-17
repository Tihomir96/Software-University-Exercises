using System;
using System.Configuration;

namespace _4.Telephony
{
    public class Program
    {
        public static void Main()
        {
            var phones = Console.ReadLine().Split();
            var smartphone =new Smartphone();
            foreach (var phone in phones)
            {
                try
                {
                    Console.WriteLine(smartphone.Calling(phone));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            var urls =Console.ReadLine().Split();
            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(smartphone.Browsing(url));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
