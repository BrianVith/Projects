using Fællessystem.Model.Enums;

namespace Fællessystem.Model
{
    public interface IArea
    {
        int? AreaID { get; set; }
        Areas AreaName { get; set; }
    }
}