namespace Adapter;

public class Plane : IAirTransport
{
    public string Name { get; private set; }
    public Plane(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }
}