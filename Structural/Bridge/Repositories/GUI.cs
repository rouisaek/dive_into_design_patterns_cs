using Bridge.Interfaces;

namespace Bridge.Repositories
{
    public class GUI
    {
        private readonly IPlatformOs _platformOs;

        public GUI(IPlatformOs platformOs)
        {
            _platformOs = platformOs;
        }

        public void Boot()
        {
            _platformOs.Init();
        }
    }
}