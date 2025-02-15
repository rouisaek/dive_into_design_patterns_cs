using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Windows
{
    public class WinButton : IButtonBase
    {
        public void Paint()
        {
            // Render a button in Windows style.
            Console.WriteLine("Render a button in Windows style.");
        }
    }
}