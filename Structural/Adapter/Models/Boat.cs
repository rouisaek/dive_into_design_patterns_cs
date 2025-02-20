namespace Adapter;

public class Boat : IOceanTransport
{
    public string Name { get; private set; }
    public Boat(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }
}
