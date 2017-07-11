using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Advertisement_Message
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            string[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int randomPhrase = random.Next(0, phrases.Length-1);
                int randomEvent = random.Next(0, events.Length - 1);
                int randomAuthor = random.Next(0, authors.Length - 1);
                int randomCity = random.Next(0, cities.Length - 1);

                string phrase = phrases[randomPhrase];
                string eventa = events[randomEvent];
                string author = authors[randomAuthor];
                string  city= cities[randomCity];


                Console.WriteLine($"{phrase}{eventa}{author} - {city}");

            }



        }
    }
}
