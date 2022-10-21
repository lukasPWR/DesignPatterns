// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");


var strategy = new CarStrategy();

var map = new Map(strategy);

var start = new Coordinate();
var stop = new Coordinate();

map.createRoute(start, stop);