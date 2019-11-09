using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson 8 : Inheritance 

            // 8.1 - Inheritance basics
            //Parent class is PresentationObject and child class is Text

            //var text = new Text();
            //text.Width = 100;
            //text.Copy();

            //-------------------------------------------------------

            //8.2 - Composition

            //var logger = new Logger();
            //var migrator = new DbMigrator(logger);

            //migrator.Migrate();

            //-------------------------------------------------------

            //8.3 Inheritance constructors

            var car = new Car("12345");

            //-------------------------------------------------------
        }
    }
}
