using Fællessystem.Persistence;
using System.Data.SqlClient;

namespace Fællessystem
{
    public static class FactorySQL
    {
        public static SqlConnection CreateSQLConnection()
        {
            return new SqlConnection(Connection.ConnectionString);
        }

        public static SqlCommand CreateSQLCommand(string commandText, SqlConnection connection)
        {
            return new SqlCommand(commandText, connection);
        }
    }
}
