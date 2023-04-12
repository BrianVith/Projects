using Fællessystem.Model.Enums;

namespace Fællessystem.Model
{
    public class MemberList
    {
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string RoleName { get; set; }
        public int? TicketID { get; set; }
        public int? FreeTicketID { get; set; }
        public FoodChoices FoodChoiceName { get; set; }
        public TicketTypes TicketTypeName { get; set; }


        public MemberList(string memberName = "", string email = "", string phoneNumber = "", string roleName = "", int? ticketID = null, int? freeTicketID = null, FoodChoices foodChoiceName = 0, TicketTypes ticketTypeName = 0)
        {
            MemberName = memberName;
            Email = email;
            PhoneNumber = phoneNumber;
            RoleName = roleName;
            TicketID = ticketID;
            FreeTicketID = freeTicketID;
            FoodChoiceName = foodChoiceName;
            TicketTypeName = ticketTypeName;
        }
    }
}
