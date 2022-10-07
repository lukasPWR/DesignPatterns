using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class CityDuck: Duck
    {
        public override void Swim()
        {
            Console.WriteLine("Swim");
        }

        public override void Quack()
        {
            Console.WriteLine("City Quack");
        }

        public override void Fly()
        {
            Console.WriteLine("City Duck flies");
        }
    }
}
