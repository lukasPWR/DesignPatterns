// See https://aka.ms/new-console-template for more information

using Builder;

Console.WriteLine("Hello, World!");

var builder = new InvoiceBuilder();
var invoice =builder.SetDate(new DateTime(2020,1,1))
    .SetInvoiceNumber("1")
    .SetVendor("Google")
    .SetVendee("Vendee")
    .SetLinetItems(new List<string>(){"line item1", "line item2"})
    .Build();

var builder2 = new Director();
var invoice2 = builder2.CreateMonthInvoice(new DateTime(2000, 1, 1));
Console.WriteLine(invoice.Vendee);
Console.WriteLine(invoice.Vendor);
Console.WriteLine(invoice2.Date);