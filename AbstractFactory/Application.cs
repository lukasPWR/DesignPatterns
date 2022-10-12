using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Application
    {
        private readonly IUIElementFactory _elementFactory;

        public Application(IUIElementFactory elementFactory)
        {
            _elementFactory = elementFactory;

        }

        public void RenderUI()
        {
            var createNewFileButton = _elementFactory.CreateButton();

            createNewFileButton.Render();

            var textBox = _elementFactory.CreateTextBox();

            textBox.Render();
            
        }
    }
}
