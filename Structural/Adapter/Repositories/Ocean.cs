namespace Adapter;

public class Ocean
{
    private readonly IOceanTransport _t;
    public Ocean(IOceanTransport t)
    {
        _t = t;
    }

    public string GetOceanTransportName()
    {
        return _t.GetName();
    }
}
