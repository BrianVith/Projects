using Fællessystem.Model.Enums;
using System;

namespace Fællessystem.Model
{
    public class Ticket : ITicket
    {
        public int? TicketID { get; set; }
        public TicketTypes TicketType { get; set; }
        public FoodChoices FoodChoice { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int? MemberID { get; set; }
        public int? FoodChoiceID { get; set; }
        public int? TicketTypeID { get; set; }
        public int? TaskID { get; set; }

        public Ticket() { PurchaseDate = DateTime.Now; }
        public Ticket(int? memberID, TicketTypes ticketType, FoodChoices foodChoice, int? ticketID)
        {
            MemberID = memberID;
            TicketType = ticketType;
            FoodChoice = foodChoice;
            PurchaseDate = DateTime.Now;
            TicketTypeID = ticketID;
        }
    }
}
