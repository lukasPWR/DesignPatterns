﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class WalkStrategy : IRouteStrategy
    {
        public void createRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Walk strategy");
        }
    }
}
