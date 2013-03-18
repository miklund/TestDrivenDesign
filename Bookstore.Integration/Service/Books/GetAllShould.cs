using Bookstore.Integration.Books;
using NUnit.Framework;
using System.Linq;

namespace Bookstore.Integration.Service.Books
{
    public class GetAllShould
    {
        [Test]
        public void GetListOfBooksFromDatabase()
        {
            /* Setup */
            var client = new BooksClient();

            /* Test */
            var result = client.GetAll();

            /* Assert */
            Assert.That(result.Any(book => book.Author == "Jordan, Robert"), "Expected the result to contain a book of Robert Jordan");
        }
    }
}
