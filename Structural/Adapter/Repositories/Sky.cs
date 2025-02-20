namespace Adapter;

public class Sky
{
    private readonly IAirTransport _t;
    public Sky(IAirTransport t)
    {
        _t = t;
    }

    public string GetSkyTransportName()
    {
        return _t.GetName();
    }
}