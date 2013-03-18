using System.Collections.Generic;
using System.ServiceModel;
using Bookstore.Api.Model;

namespace Bookstore.Api.Contracts
{
    [ServiceContract]
    public interface IBooks
    {
        [OperationContract]
        IEnumerable<Book> GetAll();
    }
}
