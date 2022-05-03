using Fællessystem.Model.Enums;
using System;

namespace Fællessystem.Model
{
    public class FreeTicket : ITicket
    {
        public int? TicketID { get; set; }
        public FoodChoices FoodChoice { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public int? MemberID { get; set; }
        public int? FoodChoiceID { get; set; }
        public int? AreaID { get; set; }

        public FreeTicket() { }
        public FreeTicket(int? memberID, int? areaID, int? foodChoiceID)
        {
            MemberID = memberID;
            AreaID = areaID;
            FoodChoiceID = foodChoiceID;
            AcquisitionDate = DateTime.Now;
        }


    }
}
