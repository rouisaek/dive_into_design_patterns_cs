using Prototype;

try
{
    // Create a Rectangle object
    Rectangle rectangle = new Rectangle(100, 50, 10, 20, "Red");
    Console.WriteLine("Original Rectangle:");
    rectangle.Display();

    // Clone the Rectangle object
    Rectangle clonedRectangle = (Rectangle)rectangle.Clone();
    Console.WriteLine("\nCloned Rectangle:");
    clonedRectangle.Display();

    // Modify the cloned Rectangle
    clonedRectangle.X = 30;
    clonedRectangle.Color = "Blue";
    Console.WriteLine("\nModified Cloned Rectangle:");
    clonedRectangle.Display();

    // Test validation: Invalid Rectangle (Width <= 0)
    Rectangle invalidRectangle = new Rectangle(0, 50, 10, 20, "Green");
    Console.WriteLine("\nAttempting to clone invalid Rectangle...");
    Rectangle clonedInvalidRectangle = (Rectangle)invalidRectangle.Clone();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
