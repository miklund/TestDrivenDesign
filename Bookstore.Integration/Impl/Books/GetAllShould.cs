using System.Linq;
using NUnit.Framework;

namespace Bookstore.Integration.Impl.Books
{
    using Bookstore.Api.Impl;

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

        [TestCase("Fantasy")]
        [TestCase("Romance")]
        [TestCase("Horror")]
        [TestCase("Science Fiction")]
        public void IncludeGenreOnBooks(string expectedGenre)
        {
            /* Setup */
            var service = new Books();

            /* Test */
            var result = service.GetAll();

            /* Assert */
            Assert.That(result.Any(book => book.Genre == expectedGenre));
        }
    }
}
