using AbstractFactory.Interfaces;
using AbstractFactory.Models.Linux;

namespace AbstractFactory.Factories
{
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