using Fællessystem.Model;
using Fællessystem.Model.Enums;

namespace Fællessystem.ViewModel
{
    public class MemberListVM
    {
        private MemberList _memberList;
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string RoleName { get; set; }
        public int? TicketID { get; set; }
        public int? FreeTicketID { get; set; }
        public FoodChoices FoodChoiceName { get; set; }
        public TicketTypes TicketTypeName { get; set; }

        public MemberListVM(MemberList memberList)
        {
            _memberList = memberList;
            MemberName = _memberList.MemberName;
            Email = _memberList.Email;
            PhoneNumber = _memberList.PhoneNumber;
            RoleName = _memberList.RoleName;
            TicketID = _memberList.TicketID;
            FreeTicketID = _memberList.FreeTicketID;
            FoodChoiceName = _memberList.FoodChoiceName;
            TicketTypeName = _memberList.TicketTypeName;
        }
    }
}
