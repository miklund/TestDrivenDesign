using Bookstore.Features.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Bookstore.Features.Bindings
{
    [Binding]
    public class BookList : WebTest
    {
        private BookPage page;

        [When(@"jag har surfat till (.*$)")]
        public void Open(string relativeUrl)
        {
            page = OpenPage<BookPage>(BaseUrl + relativeUrl);
        }

        [Then(@"hittar jag en bok i genre (.*$)")]
        public void SaHittarJagEnBoklistaIGenrer(string genre)
        {
            var row = page.Books.FindRowInOwnTableRows(genre, 2);
            Assert.That(row, Is.Not.Null, "Expected to find book with genre " + genre);
        }
    }
}