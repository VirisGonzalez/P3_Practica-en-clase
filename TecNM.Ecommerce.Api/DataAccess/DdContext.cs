using System.Data.Common;
using MySqlConnector;
using TecNM.Ecommerce.Api.DataAccess.Interfaces;

namespace TecNM.Ecommerce.Api.DataAccess;

public class DdContext : IDbContext
{
    private readonly string _connectionString = 
        "server=localhost;user=root;password=Viris1108*;database=sys;port=3306";

    private MySqlConnection _connection;

    public DbConnection Connection
    {
        get
        {
            if (_connection == null)
            {
                _connection = new MySqlConnection(_connectionString);
            }

            return _connection;
        }
    }
}