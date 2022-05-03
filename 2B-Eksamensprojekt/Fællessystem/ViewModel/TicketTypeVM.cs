using Fællessystem.Model;
using Fællessystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fællessystem.ViewModel
{
    public class TicketTypeVM
    {
        private TicketType _ticketType;
        public int? TicketTypeID { get; set; }
        public TicketTypes TicketTypeName { get; set; }
        public double? TicketPrice { get; set; }

        public TicketTypeVM(TicketType ticketType)
        {
            _ticketType = ticketType;
            TicketTypeID = ticketType.TicketTypeID;
            TicketTypeName = ticketType.TicketTypeName;
            TicketPrice = ticketType.TicketPrice;
        }
    }
}
