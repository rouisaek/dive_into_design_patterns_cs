using AbstractFactory.Interfaces;
using AbstractFactory.Models.Linux;

namespace AbstractFactory.Factories
{
    // Concrete factories produce a family of products that belong
    // to a single variant. The factory guarantees that the
    // resulting products are compatible. Signatures of the concrete
    // factory's methods return an abstract product, while inside
    // the method a concrete product is instantiated.
    public class LinuxFactory : IFactoryBase
    {
        public IButtonBase CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckboxBase CreateCheckbox()
        {
            return new LinuxCheckbox();
        }
    }
}