using Fællessystem.Model.Enums;

namespace Fællessystem.Model
{
    public class FoodChoice
    {
        public int? FoodChoiceID { get; set; }
        public FoodChoices FoodChoiceName { get; set; }

        public FoodChoice(int? foodChoiceID, FoodChoices foodChoiceName = 0)
        {
            FoodChoiceID = foodChoiceID;
            FoodChoiceName = foodChoiceName;
        }
    }
}
