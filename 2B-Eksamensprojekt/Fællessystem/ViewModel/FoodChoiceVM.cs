using Fællessystem.Model;
using Fællessystem.Model.Enums;

namespace Fællessystem.ViewModel
{
    public class FoodChoiceVM
    {
        private FoodChoice _foodChoice;
        public FoodChoices FoodChoiceName { get; set; }
        public FoodChoiceVM(FoodChoice foodChoice)
        {
            _foodChoice = foodChoice;
            FoodChoiceName = foodChoice.FoodChoiceName;
        }
    }
}
