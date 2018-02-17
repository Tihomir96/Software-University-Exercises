using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Parse_URL
{
    class Program
    {
        static void Main()
        {
            var inputUrl = Console.ReadLine();
            var separator = "://";
            var urlTokens = inputUrl.Split(new[] {separator}, StringSplitOptions.RemoveEmptyEntries);
            if (urlTokens.Length != 2 || urlTokens[1].IndexOf('/')==-1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            else
            {
                var protocol = urlTokens[0];
                var server = urlTokens[1].Substring(0, urlTokens[1].IndexOf('/'));
                var resources = urlTokens[1].Substring(urlTokens[1].IndexOf('/'), urlTokens[1].Length - urlTokens[1].IndexOf('/'));
                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resources.Substring(1,resources.Length-1)}");
            }
        }
    }
}
