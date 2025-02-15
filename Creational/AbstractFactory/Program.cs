using AbstractFactory;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

// The application picks the factory type depending on the
// current configuration or environment settings and creates it
// at runtime (usually at the initialization stage).

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
