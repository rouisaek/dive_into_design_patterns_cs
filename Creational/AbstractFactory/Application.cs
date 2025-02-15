using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    // The client code works with factories and products only
    // through abstract types: IFactoryBase, IButtonBase and ICheckboxBase. This
    // lets you pass any factory or product subclass to the client
    // code without breaking it.

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