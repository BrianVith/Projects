using Fællessystem.Model;
using Fællessystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Fællessystem.Persistence
{
    public class VolunteerWaitingListRepository
    {
        private const string TABLE_NAME = "WaitingList";

        // Deletes the member from the waiting list, when they accept/decline their invitations(s)
        public int AcceptVolunteerAgreement(int? memberID)
        {
            int rowsAffected;

            string commandText = $"DELETE FROM {TABLE_NAME} WHERE MemberID = {memberID}";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                sqlConnection.Open();

                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);
                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected;
        }

        // Checks whether a member has any invitations to work as a volunteer on an area
        public List<Area> VerifyToWaitingList(int? memberID)
        {
            List<Area> output = FactoryModels.CreateListOfArea();

            string commandText = $"SELECT AreaName, Area.AreaID " +
                    $"FROM {TABLE_NAME} INNER JOIN Area ON WaitingList.AreaID = Area.AreaID " +
                    $"WHERE WaitingList.MemberID = {memberID}";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                sqlConnection.Open();

                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Area area = (Area)FactoryModels.CreateArea(reader[1] as int? ?? -1, (Areas)Enum.Parse(typeof(Areas), (reader[0] as string)));
                    output.Add(area);
                }
            }
            return output;
        }
    }
}
