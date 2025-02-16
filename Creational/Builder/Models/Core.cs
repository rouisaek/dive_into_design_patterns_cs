
namespace Builder.Models;

public class Core
{
    public EShape Shape { get; set; }

    public string Name { get; private set; }
    public int Defence { get; private set; }
    public int Vertices { get; private set; }

    public Core(EShape shape)
    {
        Shape = shape;
        InitializeCore();
    }

    private void InitializeCore()
    {
        switch (Shape)
        {
            case EShape.Circle:
                Defence = 35;
                Name = "Circle Core";
                Vertices = 0;
                break;
            case EShape.Triangle:
                Defence = 25;
                Name = "Triangle Core";
                Vertices = 3;
                break;
            case EShape.Square:
                Defence = 15;
                Name = "Square Core";
                Vertices = 4;
                break;
        }
    }
}