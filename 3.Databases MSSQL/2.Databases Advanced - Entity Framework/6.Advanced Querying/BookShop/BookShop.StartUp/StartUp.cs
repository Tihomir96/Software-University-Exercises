using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop
{
    using BookShop.Data;
    using BookShop.Initializer;
    
    public class StartUp
    {
        public static void Main()
        {
            using (var db = new BookShopContext())
            {
                Console.WriteLine(RemoveBooks(db));
            }
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            int enumValue = -1;
            switch (command.ToLower())
            {
                case "minor":
                    enumValue = 0;
                    break;
                case "teen":
                    enumValue = 1;
                    break;
                case "adult":
                    enumValue = 2;
                    break;                    
            }
            return string.Join(Environment.NewLine,
                context.Books.Where(x => (int)x.AgeRestriction == enumValue).Select(x => x.Title).OrderBy(x=>x));
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            return string.Join(Environment.NewLine,context.Books
                                                        .Where(x => x.EditionType == EditionType.Gold && x.Copies <5000)
                                                        .OrderBy(x=>x.BookId)
                                                        .Select(x => x.Title));
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();
            foreach (var book in context.Books.Where(x => x.Price > 40).Select(x => new
            {
                x.Title,
                x.Price
            }).OrderByDescending(x => x.Price))
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }
            return sb.ToString().Trim();
       
        }
        public static string GetBooksNotRealeasedIn(BookShopContext context, int year)
        {
            return string.Join(Environment.NewLine,context.Books
                                                        .Where(x => x.ReleaseDate.Value.Year != year)
                                                        .OrderBy(x=>x.BookId)
                                                        .Select(x => x.Title)
                                                        .ToList());
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.ToLower().Split(' ', '\t',StringSplitOptions.RemoveEmptyEntries).ToArray();
            return string.Join(Environment.NewLine, context.Books.
                                                Where(b => b.BookCategories
                                                .Any(c => categories.Contains(c.Category.Name.ToLower())))
                                                .OrderBy(x=>x.Title)
                                                .Select(x=>x.Title)
                                                .ToList());

        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var b4ReleaseDateTime = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var books =context.Books
                .Where(x => x.ReleaseDate.Value.Date < b4ReleaseDateTime)
                .OrderByDescending(x => x.ReleaseDate.Value)
                .Select(x => new
                {
                    x.Title,
                    x.EditionType,
                    x.Price
                }).ToArray();

            var sb = new StringBuilder();
            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }

            return sb.ToString().Trim();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var sb = new StringBuilder();
            context.Authors
                .Where(x => x.FirstName.EndsWith(input))
                .Select(x => new { Fullname = $"{x.FirstName} {x.LastName}"})
                .OrderBy(x => x.Fullname)
                .ToList().ForEach(e=>sb.AppendLine(e.Fullname));
             return sb.ToString().TrimEnd();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            return string.Join(Environment.NewLine, context.Books
                                                        .Where(x => x.Title.ToLower().Contains(input.ToLower()))
                                                        .OrderBy(x => x.Title)
                                                        .Select(x => x.Title));
                                                        
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var sb = new StringBuilder();
            context.Books
               .Where(x => x.Author.LastName.ToLower().StartsWith(input.ToLower()))
               .OrderBy(x => x.BookId)
               .Select(x => new
               {                   
                   FullnameAndBook = $"{x.Title} ({x.Author.FirstName} {x.Author.LastName})"
               })
               .ToList().ForEach(x=>sb.AppendLine(x.FullnameAndBook));
            return sb.ToString().Trim();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            return context.Books.Where(x => x.Title.Length > lengthCheck).Count();
        }
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var sb = new StringBuilder();
            int sum = 0;
            foreach (var author in context.Authors.Include(x=>x.Books).OrderByDescending(x=>x.Books.Select(y=>y.Copies).Sum()))
            {
                foreach (var book in author.Books)
                {
                    sum += book.Copies;
                }
                sb.AppendLine($"{author.FirstName} {author.LastName} - {sum}");
                sum = 0;
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var sb = new StringBuilder();
            var dict = new Dictionary<string,decimal>();
            decimal profit = 0;
            foreach (var category in context.Categories.Include(x=>x.CategoryBooks).ThenInclude(x=>x.Book))
            {
               
                foreach (var books in category.CategoryBooks)
                {
                     profit += books.Book.Price * books.Book.Copies;
                }
                dict.Add(category.Name,profit);
                profit = 0;
            }
            foreach (var nameAndProfit in dict.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                sb.AppendLine($"{nameAndProfit.Key} ${nameAndProfit.Value:f2}");
            }
            return sb.ToString().Trim();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var sb = new StringBuilder();
            foreach (var category in context.Categories.Include(x => x.CategoryBooks).ThenInclude(x => x.Book)
                .OrderBy(x=>x.Name))
            {
                sb.AppendLine($"--{category.Name}");
                foreach (var books in category.CategoryBooks.OrderByDescending(x=>x.Book.ReleaseDate).Take(3))
                {
                    sb.AppendLine($"{books.Book.Title} ({books.Book.ReleaseDate.Value.Year})");
                }
            }
            return sb.ToString().Trim();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            foreach (var book in context.Books.Where(x => x.ReleaseDate.Value.Year < 2010))
            {
                book.Price += 5;
            }
            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var booksToDelete = context.Books.Where(x => x.Copies < 4200).ToList();
            context.RemoveRange(booksToDelete);
            context.SaveChanges();
            return booksToDelete.Count();
        }

    }

}
