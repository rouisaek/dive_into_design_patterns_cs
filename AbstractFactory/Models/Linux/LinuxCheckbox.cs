using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Linux
{
    public class LinuxCheckbox : ICheckboxBase
    {
        public void Paint()
        {
            // Render a checkbox in Linux style.
            Console.WriteLine("Render a checkbox in Linux style.");
        }
    }
}