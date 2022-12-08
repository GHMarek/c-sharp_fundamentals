using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    class PolyClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape...");
        }
    }

    class Rectangle : PolyClass
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle...");
        }
    }

    class Circle : PolyClass
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle...");
        }
    }
}
