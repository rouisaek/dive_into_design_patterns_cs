using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Windows
{
    public class WinButton : IButtonBase
    {
        public void Paint()
        {
            Console.WriteLine("Render a checkbox in Windows style.");
        }
    }
}