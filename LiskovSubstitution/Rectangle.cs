using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class Rectangle
    {
        protected int _height;
        protected int _width;

        public virtual void SetHeigh(int heigh)
        {
            _height = heigh;
        }

        public virtual void SetWidth(int width)
        {
            _width = width;
        }
    }
}
