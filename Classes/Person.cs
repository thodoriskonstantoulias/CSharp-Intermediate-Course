using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string name)
        {
            Console.WriteLine("Hello {0}, I am {1} ", name, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
}
