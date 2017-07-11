using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _05.Book_Library
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.Books = new List<Book>();
            Book book;
            var result = new Dictionary<string, DateTime>();


            for (int i = 0; i < n; i++)
            {
                book = new Book();
                var input = Console.ReadLine().Split(' ');
                string date = input[3];
                book.title = input[0];
                book.author = input[1];
                book.publisher = input[2];
                book.releaseDate = DateTime.ParseExact(date,"dd.MM.yyyy",CultureInfo.InvariantCulture);
                book.isbn = input[4];
                book.price = double.Parse(input[5]);
                library.Books.Add(book);
            }

            var date2= DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                
            foreach (var boo in library.Books)
            {
                if (!result.ContainsKey(boo.title))
                {
                if (DateTime.Compare(date2,boo.releaseDate )< 0)
                    {
                    result.Add(boo.title, boo.releaseDate);
                    }

                }
            }
            var result1 = result.OrderBy(g => g.Value).ThenBy(s => s.Key);
            foreach (var results in result1)
            {
                Console.WriteLine($"{results.Key} -> {results.Value.ToString("dd.MM.yyyy")}");

            }
        }
    }
}
