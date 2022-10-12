using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WindowsButton:IButton
    {
        public void Render()
        {
            Console.WriteLine("Render Windows Button");
        }

        public void HandleClick()
        {
            Console.WriteLine("Handle windows click event");
        }
    }
}
