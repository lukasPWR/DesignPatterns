// See https://aka.ms/new-console-template for more information

using DesignPatterns;

Console.WriteLine("Hello, World!");

IPrinter printer = GetPrinter();
printer.Print("XD");


static IPrinter GetPrinter()
{
    return new Hp();
}