using FluentMigrator;

namespace Bookstore.Api.Migrations
{
    [Migration(1)]
    public class CreateBookTable : Migration
    {
        public override void Up()
        {
            Create.Table("books")
                  .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                  .WithColumn("title").AsString().NotNullable()
                  .WithColumn("author").AsString().NotNullable()
                  .WithColumn("genre").AsString().NotNullable()
                  .WithColumn("price").AsDouble().NotNullable()
                  .WithColumn("publish_date").AsDate().NotNullable()
                  .WithColumn("description").AsCustom("text").NotNullable();
        }

        public override void Down()
        {
            Delete.Table("books");
        }
    }
}