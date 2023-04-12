using Fællessystem.Model;
using Fællessystem.Model.Enums;
using System.Data.SqlClient;

namespace Fællessystem.Persistence
{
    public class TaskRepository
    {
        private const string TABLE_NAME = "Task";
       
        public int GetID(Tasks task)
        {
            string commandText = $"SELECT TaskID FROM {TABLE_NAME} WHERE TaskName = '{task.ToString()}'";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                sqlConnection.Open();

                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);

                return command.ExecuteScalar() as int? ?? -1;
            }
        }
    }
}
