using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Linux
{
    // Concrete products are created by corresponding concrete
    // factories.
    public class LinuxButton : IButtonBase
    {
        public void Paint()
        {
            // Render a button in Linux style.
            Console.WriteLine("Render a button in Linux style.");
        }
    }
}