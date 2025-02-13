using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class Square : IShape
    {
        // Draw a square shape.
        public void Draw() => Console.WriteLine("□");
    }
}