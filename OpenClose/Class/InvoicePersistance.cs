using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClose.Class;

namespace SingleResponsibility
{
    internal class InvoicePersistance
    {
        private Invoice _invoice;
        private IInvoiceServer _invoiceSaver;

        public InvoicePersistance(Invoice invoice, IInvoiceServer invoiceSaver )
        {
            _invoice = invoice;
            _invoiceSaver = invoiceSaver;
        }

        public void Save()
        {
            _invoiceSaver.Save(_invoice);
        }
    }
}
