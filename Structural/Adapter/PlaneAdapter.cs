namespace Adapter;

public class PlaneAdapter : IOceanTransport
{
    private readonly Boat _boat;

    public PlaneAdapter(Boat boat)
    {
        _boat = boat;
    }

    public string GetName()
    {
        return _boat.GetName();
    }
}