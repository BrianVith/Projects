using Fællessystem.Model.Enums;

namespace Fællessystem.Model
{
    public class Area : IArea
    {
        public int? AreaID { get; set; }
        public Areas AreaName { get; set; }

        public Area() { }
        public Area(int? areaID, Areas areaName)
        {
            AreaID = areaID;
            AreaName = areaName;
        }

    }
}
