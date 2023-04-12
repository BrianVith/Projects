using Fællessystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fællessystem.ViewModel.EventArgs
{
    public class PurchaseTicketEventArgs
    {
        public TicketTypes TicketType { get; set; }
        public decimal TicketPrice { get; set; }
        public FoodChoices FoodChoice { get; set; }
        public Tasks Task { get; set; }
    }
}
