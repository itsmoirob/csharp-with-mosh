using System;

namespace _02_classes
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
