using AbstractFactory.Interfaces;
using AbstractFactory.Models.Windows;

namespace AbstractFactory.Factories
{
    // Each concrete factory has a corresponding product variant.
    public class WinFactory : IFactoryBase
    {
        public IButtonBase CreateButton()
        {
            return new WinButton();
        }

        public ICheckboxBase CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
}