using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Triangle: Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render Triangle");
        }

        public override Shape Clone()
        {
            return (Triangle)this.MemberwiseClone();
        }
    }
}
