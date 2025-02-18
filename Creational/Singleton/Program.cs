using Singleton;

var db2 = Database.GetDbInstance();
var db3 = Database.GetDbInstance();
Console.WriteLine(db2 == db3);

// var db0 = DatabaseThreadSafe.Instance;
// var db1 = DatabaseThreadSafe.Instance;
// Console.WriteLine(db0 == db1);