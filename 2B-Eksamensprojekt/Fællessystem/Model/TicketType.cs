using Fællessystem.Model.Enums;

namespace Fællessystem.Model
{
    public class TicketType
    {
        public int? TicketTypeID { get; set; }
        public TicketTypes TicketTypeName { get; set; }
        public double? TicketPrice { get; set; }
    }
}
