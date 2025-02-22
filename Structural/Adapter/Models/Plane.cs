namespace Adapter;

public class Plane : IAirTransport
{
    private string Name { get; set; }
    public Plane(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }
}