using AbstractFactory;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

IFactoryBase factory;

if (OperatingSystem.IsLinux())
{
    factory = new LinuxFactory();
}
else if (OperatingSystem.IsWindows())
{
    factory = new WinFactory();
}
else
{
    throw new PlatformNotSupportedException("Error! Unknown operating system.");
}

var app = new Application(factory);

app.CreateStyle();
app.PaintStyle();
