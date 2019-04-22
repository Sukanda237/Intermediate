using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {

            var dbMigration = new DbMigrator(new Logger());
            var logger = new Logger();
            var Installer = new Installer(logger);

            dbMigration.Migrate();
            Installer.Install();

            Console.ReadKey();
        }
    }
}
