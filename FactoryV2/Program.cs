// See https://aka.ms/new-console-template for more information

using BuilderV2;

Console.WriteLine("Hello, World!");


var carDirector = new CarDirector();
var bmwBuilder = new BmwBuilder();

carDirector.ConstructCar(bmwBuilder);
var bmw = bmwBuilder.GetCar();
Console.WriteLine(bmw.EngineType);
