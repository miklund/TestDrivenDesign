using Massive;

namespace Bookstore.Api.DataAccess
{
    public class Books : DynamicModel
    {
        public Books()
            : base(connectionStringName: "db", tableName: "books", primaryKeyField: "id")
        {
        }
    }
}