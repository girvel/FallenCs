using EcsCs;
using EcsDemo;

Console.WriteLine("Hello, World!");

var entity = new Entity(
    new Position(new Int2(3, 2)));

Console.WriteLine(entity.GetComponent<Position>().Vector);
