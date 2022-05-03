using Fællessystem.Model.Enums;

namespace Fællessystem.Model
{
    public interface ITicket
    {
        public int? TicketID { get; set; }
        public FoodChoices FoodChoice { get; set; }
    }
}
