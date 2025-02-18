namespace Singleton;

public class DatabaseThreadSafe
{
    // Static readonly instance initialized eagerly
    private static readonly DatabaseThreadSafe _instance = new();

    // Private constructor to prevent instantiation
    private DatabaseThreadSafe() { }

    // Public method to provide access to the Singleton instance
    public static DatabaseThreadSafe Instance => _instance;

    // Lazy Initialization method.
    // private static readonly Lazy<DatabaseThreadSafe> _lazyInstance = new(() => new DatabaseThreadSafe());
    // public static DatabaseThreadSafe Instance => _lazyInstance.Value;
}