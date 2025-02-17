namespace Prototype;

// Concrete prototype. The cloning method creates a new object
// and passes it to the constructor. Until the constructor is
// finished, it has a reference to a fresh clone. Therefore,
// nobody has access to a partly-built clone. This keeps the
// cloning result consistent.
public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    // A parent constructor call is needed to copy private
    // fields defined in the parent class.
    public Rectangle(int width, int height, int x, int y, string color)
        : base(x, y, color)
    {
        Width = width;
        Height = height;
    }

    public override Shape Clone()
    {
        if (this == null)
        {
            throw new InvalidOperationException("Cannot clone a null object.");
        }

        if (Width <= 0 || Height <= 0)
        {
            throw new InvalidOperationException("Width and Height must be greater than 0.");
        }

        if (string.IsNullOrEmpty(Color))
        {
            throw new InvalidOperationException("Color must be specified.");
        }

        Console.WriteLine($"Cloning Rectangle: Width={Width}, Height={Height}, X={X}, Y={Y}, Color={Color}");

        var clonedRectangle = new Rectangle(Width, Height, X, Y, Color);

        if (clonedRectangle == null)
        {
            throw new InvalidOperationException("Cloning failed: Resulting object is null.");
        }

        return clonedRectangle;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Width: {Width}, Height: {Height}");
    }


}