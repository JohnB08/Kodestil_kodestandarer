
//Siden namespaces reflekterer folderstrukturen, er det lett å linke prosjektkode sammen.
using Kodestil_kodestandarer.Interfaces;

namespace Kodestil_kodestandarer.Classes;
public class DatabaseModel : IDatabaseModel
{
    public List<string> Names {get;set;} = [];

    //private fields og properties skrives med _camelCase, legg merke til _

    private string _connectionString {get;set;} = string.Empty;

    //Metoder sine parametere, regnes som locally scoped, så skal skrives i camelCase.
    public void GetConnectionString(string databaseType)
    {
        _connectionString = GetDatabaseParameters(databaseType);
    }

    private static string GetDatabaseParameters(string databaseType)
    {
        return databaseType switch 
        {
            "postgresql" => "Host=localhost;Port=5432;Database=mydatabase;Username=myuser;Password=mypassword;",
            "mySql" => "Server=localhost;Database=mydatabase;User=myuser;Password=mypassword;",
            "sqlite" => "Data Source=mydatabase.db",
            "mongodb" => "mongodb://myusername:mypassword@cluster0-shard-00-00.mongodb.net:27017,cluster0-shard-00-01.mongodb.net:27017,cluster0-shard-00-02.mongodb.net:27017/mydatabase?ssl=true&replicaSet=atlas-cluster0&authSource=admin&retryWrites=true&w=majority",
            _ => throw new ArgumentException("Not implementet")
        };
    }
}
