using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Repositories
{
    public class TriangleCreator : ShapeCreatorBase
    {
        protected override IShape CreateShape() => new Triangle();
    }
}