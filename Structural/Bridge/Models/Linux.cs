using Bridge.Interfaces;

namespace Bridge.Models
{
    public class Linux : IPlatformOs
    {
        public void Init()
        {
            Console.Clear();
            int loop = 0;
            while (loop < 5)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write('│');
                Thread.Sleep(100);
                Console.SetCursorPosition(0, 0);
                Console.Write('╱');
                Thread.Sleep(100);
                Console.SetCursorPosition(0, 0);
                Console.Write('─');
                Thread.Sleep(100);
                Console.SetCursorPosition(0, 0);
                Console.Write('╲');
                Thread.Sleep(100);
                loop++;
            }
            Console.Clear();
            ShowSystemInformation();
        }

        private void ShowSystemInformation()
        {
            Console.WriteLine("Username: " + Environment.UserName);
            Console.WriteLine("Processor Count: " + Environment.ProcessorCount);
            Console.WriteLine("OS Version: " + Environment.OSVersion);
            Console.WriteLine("Machine Name: " + Environment.MachineName);
        }

    }
}