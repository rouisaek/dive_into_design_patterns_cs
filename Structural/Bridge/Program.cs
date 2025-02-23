using Bridge.Models;
using Bridge.Repositories;

GUI gui = null;

if (OperatingSystem.IsLinux())
{
    gui = new GUI(new Linux());
}
else if (OperatingSystem.IsWindows())
{
    gui = new GUI(new Windows());
}
else if (OperatingSystem.IsMacOS())
{
    gui = new GUI(new MacOs());
}

gui.Boot();