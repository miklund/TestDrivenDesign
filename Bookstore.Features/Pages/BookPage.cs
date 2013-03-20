using WatiN.Core;

namespace Bookstore.Features.Pages
{
    public class BookPage : Page
    {
        private const string BooksTableName = "booksTbl";

        public Table Books
        {
            get { return Document.Table(Find.ById(BooksTableName)); }
        }
    }
}
