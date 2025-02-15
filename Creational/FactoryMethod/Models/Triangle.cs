using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class Triangle : IShape
    {
        // Draw a triangle shape.
        public void Draw() => Console.WriteLine("△");
    }
}