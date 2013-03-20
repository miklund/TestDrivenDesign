using System.Configuration;
using System.Diagnostics;

namespace Bookstore.Integration
{
    public static class Database
    {
        private const string Migrator = @"..\..\..\packages\FluentMigrator.1.0.6.0\tools\migrate.exe";

        private static ProcessStartInfo Migration(bool migrateUp)
        {
            var arguments = string.Format(
                @"/connection ""{0}"" /db sqlserver2008 -assembly ""{1}"" --task {2} --profile=Test",
                ConfigurationManager.ConnectionStrings["db"].ConnectionString,
                @"..\..\..\Bookstore.Api\obj\Debug\Bookstore.Api.dll",
                migrateUp ? "migrate" : "rollback:all");

            return new ProcessStartInfo(Migrator, arguments) { UseShellExecute = false };
        }

        public static void SetUp()
        {
            var process = Process.Start(Migration(migrateUp: true));
            process.WaitForExit();
        }

        public static void TearDown()
        {
            var process = Process.Start(Migration(migrateUp: false));
            process.WaitForExit();
        }
    }
}
