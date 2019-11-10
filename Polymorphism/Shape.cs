using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing in shape class");
        }
        public abstract void Draw2();
    }
}
