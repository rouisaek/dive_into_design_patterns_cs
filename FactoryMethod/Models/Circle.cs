using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class Circle : IShape
    {
        // Draw a circle shape.
        public void Draw() => Console.WriteLine("○");
    }
}