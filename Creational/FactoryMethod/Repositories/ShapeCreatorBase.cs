using FactoryMethod.Interfaces;

namespace FactoryMethod.Repositories
{
    // The creator class declares the factory method that must
    // return an object of a product class. The creator's subclasses
    // usually provide the implementation of this method.
    public abstract class ShapeCreatorBase
    {
        // The creator may also provide some default implementation
        // of the factory method.

        /// <summary>
        /// This method is responsible for creating objects in subclasses.
        /// </summary>
        /// <returns>Abstract product `IShape`</returns>
        protected abstract IShape CreateShape();

        // Note that, despite its name, the creator's primary
        // responsibility isn't creating products. It usually
        // contains some core business logic that relies on product
        // objects returned by the factory method. Subclasses can
        // indirectly change that business logic by overriding the
        // factory method and returning a different type of product
        // from it.

        // Call the factory method to create a product object.
        public IShape GetShape() => CreateShape();
    }
}