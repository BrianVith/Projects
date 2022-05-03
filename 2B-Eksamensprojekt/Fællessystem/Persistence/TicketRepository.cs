using Fællessystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fællessystem.Persistence
{
    public class TicketRepository
    {
        private const string TABLE_NAME = "Ticket";
        public int Add(ITicket iTicket)
        {
            int rowsAffected = -1;
            if (iTicket is Ticket ticket)
            {
                string commandText = "INSERT INTO Ticket(PurchaseDate, FoodChoiceID, TicketTypeID, TaskID, MemberID)" +
                    "VALUES (@PurchaseDate, @FoodChoiceID, @TicketTypeID, @TaskID, @MemberID);";

                using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
                {
                    sqlConnection.Open();
                    SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);

                    command.Parameters.AddWithValue("@PurchaseDate", ticket.PurchaseDate);
                    command.Parameters.AddWithValue("@FoodChoiceID", ticket.FoodChoiceID);
                    command.Parameters.AddWithValue("@TicketTypeID", ticket.TicketTypeID);
                    command.Parameters.AddWithValue("@TaskID", ticket.TaskID);
                    command.Parameters.AddWithValue("@MemberID", ticket.MemberID);

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public List<Ticket> GetByID(int? memberID)
        {
            List<Ticket> output = FactoryModels.CreateListOfTicket();

            string commandText = $"SELECT TicketID, PurchaseDate, FoodChoiceID, TicketTypeID, TaskID FROM {TABLE_NAME} WHERE MemberID = {memberID}";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                sqlConnection.Open();

                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    Ticket ticket = (Ticket)FactoryModels.CreateTicket();
                    ticket.TicketID = reader[0] as int?;
                    ticket.PurchaseDate = reader[1] as DateTime?;
                    ticket.FoodChoiceID = reader[2] as int?;
                    ticket.TicketTypeID = reader[3] as int?;
                    ticket.TaskID = reader[4] as int?;
                    ticket.MemberID = memberID;

                    output.Add(ticket);
                }
                return output;
            }
        }
    }
}
