using Fællessystem.Model.Enums;
using System.Data.SqlClient;

namespace Fællessystem.Persistence
{
    public class AreaRepository
    {
        private const string TABLE_NAME = "Area";

        // Retrieves an area based on its name
        public int GetID(Areas areaName)
        {
            string commandText = $"SELECT AreaID FROM {TABLE_NAME} WHERE AreaName = '{areaName}'";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                sqlConnection.Open();

                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);

                return command.ExecuteScalar() as int? ?? -1;
            }
        }
    }
}

