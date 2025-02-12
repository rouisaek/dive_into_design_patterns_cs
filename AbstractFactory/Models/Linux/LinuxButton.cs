using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Linux
{
    public class LinuxButton : IButtonBase
    {
        public void Paint()
        {
            Console.WriteLine("Render a button in Linux style.");
        }
    }
}