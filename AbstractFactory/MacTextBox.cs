using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class MacTextBox: ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render Mac TextBox");
        }

        public void HandleInput()
        {
            Console.WriteLine("Handle Mac TextBox input");
        }
    }
}
