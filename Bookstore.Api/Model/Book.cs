using System;

namespace Bookstore.Api.Model
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public DateTime Published { get; set; }
    }
}