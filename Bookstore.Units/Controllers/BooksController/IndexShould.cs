using Bookstore.Units.Mocks;

namespace Bookstore.Units.Controllers.BooksController
{
    using System.Web.Mvc;
    using NUnit.Framework;
    using Bookstore.Web.Controllers;

    public class IndexShould
    {
        [Test]
        public void ReturnListOfBooksFromApi()
        {
            /* Setup */
            var booksClient = new BooksClientMock();
            var controller = new BooksController(booksClient.Object);

            /* Test */
            var result = controller.Index() as ViewResult;

            /* Assert */
            Assert.That(result.Model, Is.EqualTo(booksClient.Books));
        }
    }
}
