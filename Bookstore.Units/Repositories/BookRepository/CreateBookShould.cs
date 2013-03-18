using System;
using System.Dynamic;
using NUnit.Framework;

namespace Bookstore.Units.Repositories.BookRepository
{
    using Bookstore.Api.Repositories;

    public class CreateBookShould
    {
        const string Title = "Eye of the World";
        const string Author = "Jordan, Robert";
        const double Price = 4.95;
        readonly DateTime Published = DateTime.Parse("2001-01-01");

        private dynamic CreateExpandoObject()
        {
            dynamic book = new ExpandoObject();
            book.title = Title;
            book.author = Author;
            book.price = Price;
            book.publish_date = Published;

            return book;
        }

        [Test]
        public void MapAuthorToObjectInstance()
        {
            /* Setup */
            dynamic book = CreateExpandoObject();

            /* Test */
            var result = BookRepository.CreateBook(book);

            /* Assert */
            Assert.That(result.Author, Is.EqualTo(Author));
        }

        [Test]
        public void MapTitleToObjectInstance()
        {
            /* Setup */
            dynamic book = CreateExpandoObject();

            /* Test */
            var result = BookRepository.CreateBook(book);

            /* Assert */
            Assert.That(result.Title, Is.EqualTo(Title));
        }

        [Test]
        public void MapPriceToObjectInstance()
        {
            /* Setup */
            dynamic book = CreateExpandoObject();

            /* Test */
            var result = BookRepository.CreateBook(book);

            /* Assert */
            Assert.That(result.Price, Is.EqualTo(Price));
        }

        [Test]
        public void MapPublishedToObjectInstance()
        {
            /* Setup */
            dynamic book = CreateExpandoObject();

            /* Test */
            var result = BookRepository.CreateBook(book);

            /* Assert */
            Assert.That(result.Published, Is.EqualTo(Published));
        }
    }
}
