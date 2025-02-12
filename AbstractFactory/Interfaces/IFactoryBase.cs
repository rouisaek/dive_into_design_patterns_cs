namespace AbstractFactory.Interfaces
{
    public interface IFactoryBase
    {
        IButtonBase CreateButton();
        ICheckboxBase CreateCheckbox();
    }
}