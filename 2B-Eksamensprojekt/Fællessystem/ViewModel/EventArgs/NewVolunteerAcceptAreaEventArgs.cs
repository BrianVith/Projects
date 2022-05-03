using Fællessystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fællessystem.ViewModel.EventArgs
{
    public class NewVolunteerAcceptAreaEventArgs
    {
        public FoodChoices FoodChoice { get; set; }
        public Areas Area { get; set; }
    }
}
