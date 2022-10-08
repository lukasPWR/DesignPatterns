using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        private IInvoiceBuilder _builder =  new InvoiceBuilder();

        public Invoice CreateMonthInvoice(DateTime date)
        {
           var invoice = _builder.SetDate(date).Build();
           return invoice;
        }
    }
}
