using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Circle: Shape
    {
        public int Radius { get; set; }
        public override void Render()
        {
            Console.WriteLine("Render Circle");
        }

        public override Shape Clone()
        {
            Circle cloneBase = (Circle)this.MemberwiseClone();
            cloneBase.Border = new Border()
            {
                Size = Border.Size,
                Color = Border.Color
            };
            return cloneBase;
        }
    }
}
