using Fællessystem.Model;
using Fællessystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fællessystem.Persistence
{
    public class FoodChoiceRepository
    {
        private const string TABLE_NAME = "FoodChoice";

        public List<FoodChoice> GetAll()
        {
            List<FoodChoice> output = FactoryModels.CreateListOfFoodchoice();

            string commandText = "SELECT FoodChoice.FoodChoiceID, FoodChoice.FoodChoice FROM FoodChoice";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);
                sqlConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    FoodChoice foodChoice = FactoryModels.CreateFoodchoice(
                        foodChoiceID: (int)reader[0],
                        foodChoiceName: (FoodChoices)Enum.Parse(typeof(FoodChoices), (string)reader[1]));

                    output.Add(foodChoice);
                }
            }
            return output;
        }

        // Retrieves a Foodchoice based on its name
        public int GetID(FoodChoices foodChoice)
        {
            string commandText = $"SELECT FoodChoiceID FROM {TABLE_NAME} WHERE FoodChoice = '{foodChoice}'";

            using (SqlConnection sqlConnection = FactorySQL.CreateSQLConnection())
            {
                sqlConnection.Open();

                SqlCommand command = FactorySQL.CreateSQLCommand(commandText, sqlConnection);

                return command.ExecuteScalar() as int? ?? -1;
            }
        }
    }
}
