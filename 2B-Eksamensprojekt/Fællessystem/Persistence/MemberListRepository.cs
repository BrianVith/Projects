using Fællessystem.Model;
using Fællessystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fællessystem.Persistence
{
    public class MemberListRepository
    {
        private const string TABLE_NAME = "Member";

        public List<MemberList> GetAll()
        {
            List<MemberList> output = FactoryModels.CreateListOfMemberList();

            string commandText = "SELECT Member.MemberName, Member.Email, Member.PhoneNumber, [Role].RoleName, Ticket.TicketID, FreeTicketID, " +
                $"coalesce(f1.FoodChoice, f2.FoodChoice) as FoodChoice, TicketType.TicketType FROM {TABLE_NAME} " +
                "left join Ticket ON Ticket.MemberID = Member.MemberID " +
                "left outer join FreeTicket on FreeTicket.MemberID = Member.MemberID " +
                "left outer join FoodChoice as f1 ON f1.FoodChoiceID = Ticket.FoodChoiceID " +
                "left outer join FoodChoice as f2 ON f2.FoodChoiceID = FreeTicket.FoodChoiceID " +
                "left outer join TicketType on TicketType.TicketTypeID = Ticket.TicketTypeID " +
                "Left outer join MemberRole ON MemberRole.MemberID = Member.MemberID " +
                "left outer join [Role] ON [Role].RoleID = MemberRole.RoleID;";
            

            using (SqlConnection connection = FactorySQL.CreateSQLConnection())
            {
                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MemberList allMembers = FactoryModels.CreateMemberList();
                    allMembers.MemberName = reader[0] as string;
                    allMembers.Email = reader[1] as string;
                    allMembers.PhoneNumber = reader[2] as string;
                    allMembers.RoleName = reader[3] as string;
                    allMembers.TicketID = reader[4] as int?;
                    allMembers.FreeTicketID = reader[5] as int?;
                    allMembers.FoodChoiceName = Convert.IsDBNull(reader[6]) ? 0 : ((FoodChoices)Enum.Parse(typeof(FoodChoices), (string)reader[6]));
                    allMembers.TicketTypeName = Convert.IsDBNull(reader[7]) ? 0 : ((TicketTypes)Enum.Parse(typeof(TicketTypes), (string)reader[7]));
                    output.Add(allMembers);
                }
            }
            return output;
        }
    }
}
