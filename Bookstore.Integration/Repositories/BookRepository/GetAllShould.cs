using System.Linq;
using NUnit.Framework;

namespace Bookstore.Integration.Repositories.BookRepository
{
    using Bookstore.Api.Repositories;

    public class GetAllShould
    {
        [SetUp]
        public void SetUp()
        {
            Database.SetUp();
        }

        [TearDown]
        public void TearDown()
        {
            Database.TearDown();
        }

        [Test]
        public void FindThirteeenBooksInTheDatabase()
        {
            /* Setup */
            var repository = new BookRepository();

            /* Test */
            var result = repository.GetAll();

            /* Assert */
            Assert.That(result.Count(), Is.EqualTo(13));
        }

        [Test]
        public void FindBookOfRobertJordanInTheDatabase()
        {
            /* Setup */
            var repository = new BookRepository();

            /* Test */
            var result = repository.GetAll();

            /* Assert */
            Assert.That(result.Any(book => book.Author == "Jordan, Robert"));
        }
    }
}
