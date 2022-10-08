using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface IInvoiceBuilder
    {
        Invoice Build();
        InvoiceBuilder SetVendor(string vendor);
        InvoiceBuilder SetVendee(string vendee);
        InvoiceBuilder SetNote(string note);
        InvoiceBuilder SetLinetItems(IEnumerable<string> lineItems);
        InvoiceBuilder SetInvoiceNumber(string number);
        InvoiceBuilder SetDate(DateTime date);


    }
}
