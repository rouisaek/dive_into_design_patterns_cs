using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Repositories
{
    public class SquareCreator : ShapeCreatorBase
    {
        protected override IShape CreateShape() => new Square();
    }
}