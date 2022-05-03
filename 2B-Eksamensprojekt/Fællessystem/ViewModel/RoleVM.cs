using Fællessystem.Model;

namespace Fællessystem.ViewModel
{
    public class RoleVM
    {
        private Role _role;
        public string RoleName { get; set; }

        public RoleVM(Role role)
        {
            _role = role;
            RoleName = _role.RoleName;
        }
    }
}
