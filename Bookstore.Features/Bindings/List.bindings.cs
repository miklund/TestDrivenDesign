using Bookstore.Features.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace Bookstore.Features.Bindings
{
    [Binding]
    public class List : WebTest
    {
        private const string BooksListUrl = "/books";
        private BookList page;

        [When(@"jag surfar till en lista av böcker")]
        public void Goto()
        {
            page = OpenPage<BookList>(BaseUrl + BooksListUrl);
        }
        
        [Then(@"innehåller resultatet en bok av (.+$)")]
        public void FindBookByAuthor(string author)
        {
            // find book by author
            var row = page.BooksTable.FindRow(author, 1);

            Assert.That(row.Exists, Is.True, "Expected to find a book by " + author + " in books table");
        }
    }
}
