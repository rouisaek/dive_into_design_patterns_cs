using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    /// <summary>
    /// Application style based on OS.
    /// </summary>
    public class Application
    {
        public int MyProperty { get; set; }
        private IButtonBase button;
        private ICheckboxBase checkbox;
        private readonly IFactoryBase _factory;

        public Application(IFactoryBase factory)
        {
            _factory = factory;
        }

        public void CreateStyle()
        {
            button = _factory.CreateButton();
            checkbox = _factory.CreateCheckbox();
        }

        public void PaintStyle()
        {
            button.Paint();
            checkbox.Paint();
        }
    }
}