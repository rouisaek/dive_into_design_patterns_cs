using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Windows
{
    public class WinCheckbox : ICheckboxBase
    {
        public void Paint()
        {
            Console.WriteLine("Render a checkbox in Windows style.");
        }
    }
}