using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class MountainDuck: Duck
    {
        public override void Swim()
        {
            Console.WriteLine("Mountain Duck swim");
        }

        public override void Quack()
        {
            Console.WriteLine("Mountain Duck quack");
        }

        public override void Fly()
        {
            Console.WriteLine("Mountain Duck flies");
        }
    }
}
