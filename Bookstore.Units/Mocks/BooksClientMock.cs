using System.Collections.Generic;
using Bookstore.Web.Books;
using Moq;

namespace Bookstore.Units.Mocks
{
    public class BooksClientMock : Mock<IBooks>
    {
        private readonly Book[] books = new[]
            {
                new Book { Author = "Jordan, Robert" },
                new Book { Author = "Kress, Peter" }
            };

        public BooksClientMock()
        {
            Setup(mock => mock.GetAll()).Returns(books);
        }

        public IEnumerable<Book> Books
        {
            get { return this.books; }
        }
    }
}
