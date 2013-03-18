using System.Web.Mvc;
using Bookstore.Web.Books;

namespace Bookstore.Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooks booksClient;

        public BooksController(IBooks booksClient)
        {
            this.booksClient = booksClient;
        }

        public ActionResult Index()
        {
            return View(booksClient.GetAll());
        }

    }
}
