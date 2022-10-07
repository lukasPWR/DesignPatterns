using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class Cannon: IPrinter, IFax
    {
        public void PrintGray(string content)
        {
            Console.WriteLine( "Cannon print gray");

        }

        public void PrintColor(string content)
        {
            Console.WriteLine("Cannon print color");

        }


        public void Fax(string content)
        {
            Console.WriteLine("Cannon print fax");

        }
    }
}
