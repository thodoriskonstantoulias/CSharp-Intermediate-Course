using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Circle : Shape
    {
        public int FontiSize { get; set; }
        public string FontName { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Drawing in circle class");
        }

        public override void Draw2()
        {
            Console.WriteLine("Drawing in abstract circle class");
        }
    }
}
