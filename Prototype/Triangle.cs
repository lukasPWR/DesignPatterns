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
            Triangle  cloneBase =  (Triangle)this.MemberwiseClone();
            cloneBase.Border = new Border()
            {
                Size = Border.Size,
                Color = Border.Color
            };
            return cloneBase;
        }
    }
}
