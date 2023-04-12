using Fællessystem.Model.Enums;

namespace Fællessystem.Model
{
    public class VolunteerApplication
    {
        public int? VolunteerApplicationID { get; }
        public Areas Area { get; set; }
        public string Comment { get; set; }
        public int? MemberID { get; set; }

        public VolunteerApplication() { }
        public VolunteerApplication(int? memberID, Areas area, string comment)
        {
            MemberID = memberID;
            Area = area;
            Comment = comment;
        }
    }
}
