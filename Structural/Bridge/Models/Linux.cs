using Bridge.Interfaces;

namespace Bridge.Models
{
    public class Linux : IPlatformOs
    {
        public void Init()
        {
            Console.Clear();
            int loop = 0;
            Console.CursorVisible = false;
            while (loop < 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(200);
                }
                Console.Clear();
                loop++;
            }
            ShowSystemInformation();
            Console.CursorVisible = true;
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