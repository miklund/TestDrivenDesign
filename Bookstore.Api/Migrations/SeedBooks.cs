using System;
using FluentMigrator;

namespace Bookstore.Api.Migrations
{
    [Profile("Test")]
    public class SeedBooks : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("books")
                .Row(new { title = "XML Developer's Guide", author = "Gambardella, Matthew", genre = "Computer", price = 44.95, publish_date = DateTime.Parse("2000-10-01"), description = "An in-depth look at creating applications with XML." })
                .Row(new { title = "Midnight Rain", author = "Ralls, Kim", genre = "Fantasy", price = 5.95, publish_date = DateTime.Parse("2000-12-16"), description = "A former architect battles corporate zombies, an evil sorceress, and her own childhood to become queen of the world." })
                .Row(new { title = "Maeve Ascendant", author = "Corets, Eva", genre = "Fantasy", price = 5.95, publish_date = DateTime.Parse("2000-11-17"), description = "After the collapse of a nanotechnology society in England, the young survivors lay the foundation for a new society." })
                .Row(new { title = "Oberon's Legacy", author = "Corets, Eva", genre = "Fantasy", price = 5.95, publish_date = DateTime.Parse("2001-03-10"), description = "In post-apocalypse England, the mysterious agent known only as Oberon helps to create a new life for the inhabitants of London. Sequel to Maeve Ascendant." })
                .Row(new { title = "The Sundered Grail", author = "Corets, Eva", genre = "Fantasy", price = 5.95, publish_date = DateTime.Parse("2001-09-10"), description = "The two daughters of Maeve, half-sisters, battle one another for control of England. Sequel to Oberon's Legacy." })
                .Row(new { title = "Lover Birds", author = "Randall, Cynthia", genre = "Romance", price = 4.95, publish_date = DateTime.Parse("2000-09-02"), description = "When Carla meets Paul at an ornithology conference, tempers fly as feathers get ruffled." })
                .Row(new { title = "Splish Splash", author = "Thurman, Paula", genre = "Romance", price = 4.95, publish_date = DateTime.Parse("2000-11-02"), description = "A deep sea diver finds true love twenty thousand leagues beneath the sea." })
                .Row(new { title = "Creepy Crawlies", author = "Knorr, Stefan", genre = "Horror", price = 4.95, publish_date = DateTime.Parse("2000-12-06"), description = "An anthology of horror stories about roaches, centipedes, scorpions  and other insects." })
                .Row(new { title = "Paradox Lost", author = "Kress, Peter", genre = "Science Fiction", price = 6.95, publish_date = DateTime.Parse("2000-11-02"), description = "After an inadvertant trip through a Heisenberg Uncertainty Device, James Salway discovers the problems of being quantum." })
                .Row(new { title = "Microsoft .NET: The Programming Bible", author = "O'Brien, Tim", genre = "Computer", price = 36.95, publish_date = DateTime.Parse("2000-12-09"), description = "Microsoft's .NET initiative is explored in detail in this deep programmer's reference." })
                .Row(new { title = "MSXML3: A Comprehensive Guide", author = "O'Brien, Tim", genre = "Computer", price = 36.95, publish_date = DateTime.Parse("2000-12-01"), description = "The Microsoft MSXML3 parser is covered in detail, with attention to XML DOM interfaces, XSLT processing, SAX and more." })
                .Row(new { title = "Visual Studio 7: A Comprehensive Guide", author = "Galos, Mike", genre = "Computer", price = 49.95, publish_date = DateTime.Parse("2001-04-16"), description = "Microsoft Visual Studio 7 is explored in depth, looking at how Visual Basic, Visual C++, C#, and ASP+ are integrated into a comprehensive development environment." })
                .Row(new { title = "The Eye of the World", author = "Jordan, Robert", genre = "Fantasy", price = 4.95, publish_date = DateTime.Parse("1990-01-15"), description = "The Wheel of Time turns and Ages come and go, leaving memories that become legend. Legend fades to myth, and even myth is long forgotten when the Age that gave it birth returns again. In the Third Age, an Age of Prophecy, the World and Time themselves hang in the balance. What was, what will be, and what is, may yet fall under the Shadow." });
        }

        public override void Down()
        {
            // not used in seeding
        }
    }
}