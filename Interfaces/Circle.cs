using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Circle
    {
        private readonly IShape shape;

        public Circle(IShape shape)
        {
            this.shape = shape;
        }
        public void Draw()
        {
            shape.Draw();
            Console.WriteLine("Drawing a circle");
        }
    }
}
