// See https://aka.ms/new-console-template for more information

using Prototype;

Console.WriteLine("Hello, World!");

var circle = new Circle()
{
    Radius = 5,
    X= 1,
    Y =2,
    Border = new Border()
    {
        Color = "Red",
        Size = "2px"
    }
};

Circle circle2 = (Circle)circle.Clone();

bool referenceEquals = ReferenceEquals(circle,circle2);
Console.WriteLine($"Reference Equals: {referenceEquals}");

bool borderReferanceEquals = ReferenceEquals(circle.Border,circle2.Border);
Console.WriteLine($"Border Referance Equals: {borderReferanceEquals}");

Console.WriteLine();