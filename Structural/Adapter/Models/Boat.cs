namespace Adapter;

public class Boat : IOceanTransport
{
    private string Name { get; set; }
    public Boat(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }
}
