﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class Square: Rectangle
    {
        public override void SetHeigh(int height)
        {
            _width = height;
            _height = height;
        }

        public override void SetWidth(int width)
        {
            _width = width;
            _height = width;
        }
    }
}
