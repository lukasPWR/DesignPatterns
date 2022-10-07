using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleResponsibility;

namespace OpenClose.Class
{
    internal interface IInvoiceServer
    {
        void Save(Invoice invoice);
    }
}
