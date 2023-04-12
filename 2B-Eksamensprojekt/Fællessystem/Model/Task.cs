using Fællessystem.Model.Enums;

namespace Fællessystem.Model
{
    public class Task : ITask
    {
        public int? TaskID { get; set; }
        public Tasks TaskName { get; set; }
        public int? AreaID { get; set; }

        public Task() { }
        public Task(int? taskID, Tasks taskName)
        {
            TaskID = taskID;
            TaskName = taskName;
        }

    }
}
