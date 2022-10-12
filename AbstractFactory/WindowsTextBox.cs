using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WindowsTextBox: ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render Windows TextBox");
        }

        public void HandleInput()
        {
            Console.WriteLine("Handle Windows TextBox input");
        }
    }
}
