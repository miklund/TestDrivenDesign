using System.Collections.Generic;
using System.Linq;
using Bookstore.Api.DataAccess;
using Bookstore.Api.Model;

namespace Bookstore.Api.Repositories
{
    public class BookRepository
    {
        public IEnumerable<Book> GetAll()
        {
            return new Books().All().Select(CreateBook);
        }

        public static Book CreateBook(dynamic book)
        {
            return new Book
            {
                Title = book.title,
                Author = book.author,
                Genre = book.genre,
                Price = book.price,
                Published = book.publish_date
            };
        }
    }
}