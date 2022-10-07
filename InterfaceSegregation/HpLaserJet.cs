using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class HpLaserJet: IPrinter,IFax, IScanner
    {
        public void PrintGray(string content)
        {
            Console.WriteLine("Hp Laser jet print gray");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("Hp laser jet print color");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Hp laser jet print scan");

        }

        public void Fax(string content)
        {
            Console.WriteLine("Hp laser jet print fax");

        }
    }
}
