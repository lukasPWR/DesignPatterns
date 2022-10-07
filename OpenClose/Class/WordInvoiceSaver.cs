using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleResponsibility;

namespace OpenClose.Class
{
    internal class WordInvoiceSaver: IInvoiceServer
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Sawing invoice to word");
        }
    }
}
