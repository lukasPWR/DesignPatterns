using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class InvoicePersistance
    {
        private Invoice _invoice;

        public InvoicePersistance(Invoice invoice )
        {
            _invoice = invoice;
        }

        public void SaveToPdf()
        {
            Console.WriteLine($"Saving to pdf");
        }
    }
}
