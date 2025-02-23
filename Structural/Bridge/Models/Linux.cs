using Bridge.Interfaces;

namespace Bridge.Models
{
    public class Linux : IPlatformOs
    {
        public void Init()
        {
            int loop = 0;

            Console.CursorVisible = false;
            while (loop < 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(500);
                }
                Console.Clear();
                loop++;
            }
            Console.CursorVisible = true;
        }

    }
}