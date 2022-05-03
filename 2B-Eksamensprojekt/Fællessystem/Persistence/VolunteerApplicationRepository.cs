using Fællessystem.Model;
using System.Data.SqlClient;

namespace Fællessystem.Persistence
{
    public class VolunteerApplicationRepository
    {
        private const string TABLE_NAME = "VolunteerApplication";

        public int Add(VolunteerApplication volunteerApplication)
        {
            int rowsAffected = -1;
            string commandText = $"INSERT INTO {TABLE_NAME}(Comment, AreaID, MemberID)" +
                "VALUES (@Comment, @AreaID, @MemberID);";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                sqlConnection.Open();
                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);

                command.Parameters.AddWithValue("@Comment", volunteerApplication.Comment);
                command.Parameters.AddWithValue("@AreaID", (int)volunteerApplication.Area);
                command.Parameters.AddWithValue("@MemberID", volunteerApplication.MemberID);

                rowsAffected = command.ExecuteNonQuery();

            }
            return rowsAffected;
        }

    }
}
