namespace Fællessystem.Model
{
    public interface IMember
    {
        int? ActiveID { get; }
        string Email { get; set; }
        int? MemberID { get; }
        string MemberName { get; set; }
        string PhoneNumber { get; set; }
    }
}