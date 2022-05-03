using Fællessystem.Model.Enums;

namespace Fællessystem.Model
{
    public interface ITask
    {
        int? AreaID { get; set; }
        int? TaskID { get; set; }
        Tasks TaskName { get; set; }
    }
}