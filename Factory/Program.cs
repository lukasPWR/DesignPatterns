// See https://aka.ms/new-console-template for more information

using Factory;

Console.WriteLine("Hello, World!");

var shapeFactory = new ShapeFactory();

var circle = shapeFactory.CreatShape(ShapeType.Circle);
circle.Render();
