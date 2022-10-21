using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class CarStrategy : IRouteStrategy
    {
        public void createRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Cart Strategy");
        }
    }
}
