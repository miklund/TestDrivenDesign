using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookstore.Api.Contracts;
using Bookstore.Api.Model;
using Bookstore.Api.Repositories;

namespace Bookstore.Api.Impl
{
    public class Books : IBooks
    {
        public IEnumerable<Book> GetAll()
        {
            return new BookRepository().GetAll();
        }
    }
}