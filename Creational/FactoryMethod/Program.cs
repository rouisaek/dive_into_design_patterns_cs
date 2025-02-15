using FactoryMethod.Interfaces;
using FactoryMethod.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {
        ShapeCreatorBase creator = null;

        Console.Write("Select a number to draw a shape: 1. Circle 2. Square 3. Triangle: ");

        var input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                creator = new CircleCreator();
                break;
            case 2:
                creator = new SquareCreator();
                break;
            case 3:
                creator = new TriangleCreator();
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }

        if (creator is not null)
        {
            IShape shape = creator.GetShape();
            shape.Draw();
        }
    }
}