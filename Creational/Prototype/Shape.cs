namespace Prototype;

// Base prototype.
public abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Color { get; set; }

    // The prototype constructor. A fresh object is initialized
    // with values from the existing object.
    public Shape(int x, int y, string color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    // The clone operation returns one of the Shape subclasses.
    public abstract Shape Clone();

    /// <summary>
    /// Display information about the shape.
    /// </summary>
    public virtual void Display()
    {
        Console.WriteLine($"Shape: {GetType().Name}, X: {X}, Y: {Y}, Color: {Color}");
    }
}