using System;
using System.Dynamic;
using Bookstore.Api.Model;
using NUnit.Framework;

namespace Bookstore.Units.Repositories.BookRepository
{
    using Bookstore.Api.Repositories;

    public class CreateBookShould
    {
        [Test]
        public void MapGenreFromDynamic()
        {
            const string Genre = "Horror";

            /* Setup */
            var dbBook = CreateDynamicBook();
            dbBook.genre = Genre;

            /* Test */
            Book result = BookRepository.CreateBook(dbBook);
            
            /* Assert */
            Assert.That(result.Genre, Is.StringMatching(Genre));
        }

        private dynamic CreateDynamicBook()
        {
            dynamic dbBook = new ExpandoObject();
            dbBook.title = "Eye of the World";
            dbBook.author = "Jordan, Robert";
            dbBook.genre = "Fantasy";
            dbBook.publish_date = DateTime.Parse("1990-06-15");
            dbBook.price = 4.95;

            return dbBook;
        }
    }
}
