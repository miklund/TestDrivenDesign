using WatiN.Core;

namespace Bookstore.Features.Pages
{
    public class BookList : Page
    {
        private const string BookListTableName = "booksTbl";


        public Table BooksTable
        {
            get { return Document.Table(Find.ById(BookListTableName)); }
        }
    }
}
