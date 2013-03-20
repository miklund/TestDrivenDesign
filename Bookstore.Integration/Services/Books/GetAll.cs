using System.Linq;
using Bookstore.Integration.Books;
using NUnit.Framework;

namespace Bookstore.Integration.Services.Books
{
    public class GetAll
    {
        [TestCase("Fantasy")]
        [TestCase("Romance")]
        [TestCase("Horror")]
        [TestCase("Science Fiction")]
        public void IncludeGenreOnBooks(string expectedGenre)
        {
            /* Setup */
            var client = new BooksClient();

            /* Test */
            var result = client.GetAll();

            /* Assert */
            Assert.That(result.Any(book => book.Genre == expectedGenre));
        }
    }
}
