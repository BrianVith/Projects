using Fællessystem.Model;
using Fællessystem.Model.Enums;

namespace Fællessystem.ViewModel
{
    public class AreaVM
    {
        private Area _area;
        public Areas AreaName { get; set; }

        public AreaVM(Area area)
        {
            _area = area;
            AreaName = _area.AreaName;
        }
    }
}
