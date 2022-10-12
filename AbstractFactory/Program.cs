// See https://aka.ms/new-console-template for more information

using AbstractFactory;

Console.WriteLine("Hello, World!");


var app =  new Application(new WindowsFactory());

app.RenderUI();