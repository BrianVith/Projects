using Fællessystem.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fællessystem.Persistence
{
    public class RoleRepository
    {
        private const string TABLE_NAME = "Role";

        public List<Role> GetAll()
        {
            List<Role> output = FactoryModels.CreateListOfRole();

            string commandText = "SELECT Role.RoleID, Role.RoleName " +
                $"FROM {TABLE_NAME}";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);
                sqlConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Role role = new Role((int)reader[0], (string)reader[1]);
                    output.Add(role);
                }
            }
            return output;
        }
    }
}
