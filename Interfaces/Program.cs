using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson 10 : Interfaces

            //10.1 - General
            //var shape = new Shape();
            //Circle circle = new Circle(shape);
            //circle.Draw();

            //10.2 - Extensibility - Dependency Injection example
            //ex1
            var dbmigrator = new DbMigrator(new ConsoleLogger());
            dbmigrator.Migrate();

            //ex2
            // in xxx put your file path

            var dbmigrator2 = new DbMigrator(new FileLogger(@"xxx\xxx.txt"));
            dbmigrator2.Migrate();
        }
    }
}
