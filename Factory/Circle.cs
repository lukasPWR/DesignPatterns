﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Circle: Shape
    {
        public override void Render()
        {
            Console.WriteLine("render circle");
        }
    }
}
