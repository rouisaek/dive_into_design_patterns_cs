using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Repositories
{
    // Concrete creators override the factory method to change the
    // resulting product's type.
    public class CircleCreator : ShapeCreatorBase
    {
        protected override IShape CreateShape() => new Circle();
    }
}