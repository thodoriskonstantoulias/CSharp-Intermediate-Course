using System;
using System.Collections;
using System.IO;

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

            //var car = new Car("12345");

            //-------------------------------------------------------

            //8.4 Upcasting and downcasting

            //Example 1 Upcasting $$$$$$$$$$ 
            //Circle circle = new Circle();
            //Shape shape = circle;
            //circle.Width = 100;
            //shape.Width = 200;

            //Console.WriteLine(circle.Width);
            //$$$$$$$$$$$$$$$$$$$$$$$$

            //Example 2 Downcasting $$$$$$$$$$$$$

            //Shape shape = new Circle();
            //Circle circle = (Circle)shape;

            //$$$$$$$$$$$$$$$$$$$$$$$$

            //8.5 Boxing and Unboxing
            //Boxing happens when for ex. we use ArrayList which accepts objects which has perfomance issues
            //In Generic collections we do not have that problem

            var list = new ArrayList();
            list.Add(1);
            list.Add("Ted");
            list.Add(DateTime.Today);


        }
    }
}
