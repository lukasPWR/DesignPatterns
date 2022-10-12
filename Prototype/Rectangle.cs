using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Rectangle:Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render Rectangle");
        }

        public override Shape Clone()
        {
            return (Rectangle)this.MemberwiseClone();
        }
    }
}
