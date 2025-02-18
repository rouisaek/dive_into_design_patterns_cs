namespace Singleton;

public class Database
{
    private static Database _database;

    // Private constructor to prevent instantiation
    private Database() { }

    // Public method to provide access to the Singleton instance
    public static Database GetDbInstance()
    {
        if (_database == null)
        {
            _database = new Database();
        }

        return _database;
    }

}