using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class RubberDuck: Duck
    {
        public override void Swim()
        {
            Console.WriteLine("Rubber Duck swim");
        }

        public override void Quack()
        {
            Console.WriteLine("Rubber Duck quack");
        }

        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
