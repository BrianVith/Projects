using Fællessystem.Model;
using Fællessystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fællessystem.Persistence
{
    public class TicketTypeRepository
    {
        private const string TABLE_NAME = "TicketType";

        public int GetID(TicketTypes ticketType)
        {
            string commandText = $"SELECT TicketTypeID FROM {TABLE_NAME} WHERE TicketType = '{ticketType.ToString()}'";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                sqlConnection.Open();

                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);

                return command.ExecuteScalar() as int? ?? -1;
            }
        }

        public TicketType GetByID(int? ticketTypeID)
        {
            string commandText = $"SELECT TicketType FROM {TABLE_NAME} WHERE TicketTypeID = '{ticketTypeID}'";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                sqlConnection.Open();

                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);

                TicketType ticketType = FactoryModels.CreateTicketType();
                ticketType.TicketTypeName = Convert.IsDBNull(command.ExecuteScalar()) ? 0 : ((TicketTypes)Enum.Parse(typeof(TicketTypes), (string)command.ExecuteScalar()));

                return ticketType;
            }
        }

        public List<TicketType> GetAll()
        {
            List<TicketType> output = FactoryModels.CreateListOfTicketType();

            string commandtext = $"SELECT TicketType, TicketPrice, TicketTypeID From {TABLE_NAME}";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                SqlCommand command = FactorySQL.CreateSQLCommand(commandtext, sqlConnection);

                sqlConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TicketType ticketType = FactoryModels.CreateTicketType();
                    ticketType.TicketTypeName = Convert.IsDBNull(reader[0]) ? 0 : ((TicketTypes)Enum.Parse(typeof(TicketTypes), (string)reader[0]));
                    ticketType.TicketPrice = reader[1] as double?;
                    ticketType.TicketTypeID = reader[2] as int?;

                    output.Add(ticketType);
                }

                return output;
            }
        }
    }
}
