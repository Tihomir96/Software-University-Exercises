using System;
using System.Linq;
using System.Text;

namespace _2.Book_Shop
{
    public class Book
    {
        private string author;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }
        public string Author
        {
            get { return this.author; }
            protected set
            {
                var tokens = value.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length > 1)
                {
                    if (char.IsDigit(tokens[1].Trim().First()))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                
                this.author = value;
            }
        }
        private string title;
        
        public string Title
        {
            get { return this.title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }
        private decimal price;

        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }


    }
}
