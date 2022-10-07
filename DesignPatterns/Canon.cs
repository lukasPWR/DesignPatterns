using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Canon: IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine("Canon printing" + message);
        }
    }
}
