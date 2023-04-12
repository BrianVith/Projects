namespace Fællessystem.Model
{
    public class Member : IMember
    {
        public int? MemberID { get; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int? ActiveID { get; set; }

        public Member(){}
        public Member(int? memberID)
        {
            MemberID = memberID;
        }
        public Member(int? memberID, string memberName, string email, string phoneNumber)
        {
            MemberID = memberID;
            MemberName = memberName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
