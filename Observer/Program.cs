// See https://aka.ms/new-console-template for more information
using Observer;

Console.WriteLine("Hello, World!");

var subscriber1 = new Subscriber("Subscriber1");
var subscriber2 = new Subscriber("Subscriber2");

var publisher = new Publisher();

publisher.Subscribe(subscriber1);
publisher.Subscribe(subscriber2);

publisher.Notify("test messege");

publisher.Unsubscribe(subscriber1);
publisher.Notify("XD");



