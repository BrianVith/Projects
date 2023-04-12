using Fællessystem.Model;
using System.Data;
using System.Data.SqlClient;

namespace Fællessystem.Persistence
{
    public class FreeTicketRepository
    {
        private const string TABLE_NAME = "FreeTicket";

        // Creates a ticket for a Volunteer, with a given foodchoice and area to work on
        public bool Add(FreeTicket freeTicket)
        {
            string commandText = $"INSERT INTO {TABLE_NAME} (FoodChoiceID, AreaID, MemberID, AcquisitionDate)" +
                    $"VALUES (@FoodChoiceID, @AreaID, @MemberID, @AcquisitionDate)";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                sqlConnection.Open();

                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);
                command.Parameters.Add("@FoodChoiceID", SqlDbType.Int).Value = freeTicket.FoodChoiceID;
                command.Parameters.Add("@AreaID", SqlDbType.Int).Value = freeTicket.AreaID;
                command.Parameters.Add("@MemberID", SqlDbType.Int).Value = freeTicket.MemberID;
                command.Parameters.Add("@AcquisitionDate", SqlDbType.Date).Value = freeTicket.AcquisitionDate;

                command.ExecuteNonQuery();

                return true;
            }
        }

        // Retrieves a ticket based on the ID of a member
        public FreeTicket GetByID(int? memberID)
        {
            string commandText = $"SELECT FreeTicketID, FoodChoiceID, MemberID, AreaID FROM {TABLE_NAME} WHERE MemberID = {memberID}";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                sqlConnection.Open();

                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    FreeTicket ticket = (FreeTicket)FactoryModels.CreateFreeTicket();
                    ticket.TicketID = reader[0] as int?;
                    ticket.FoodChoiceID = reader[1] as int?;
                    ticket.MemberID = memberID;
                    ticket.FoodChoiceID = reader[1] as int? ?? -1;
                    ticket.AreaID = reader[3] as int? ?? -1;

                    return ticket;
                }

                return null;
            }
        }


        // Deletes a ticket based on the given MemberID
        public int DeleteID(int? memberID)
        {
            int rowsAffected;

            string commandText = $"DELETE FROM {TABLE_NAME} WHERE MemberID = {memberID}";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);
                sqlConnection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected;
        }
    }
}
