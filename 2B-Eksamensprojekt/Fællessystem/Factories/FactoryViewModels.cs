using Fællessystem.Handlers;
using Fællessystem.Model;
using Fællessystem.ViewModel;
using System.Collections.ObjectModel;

namespace Fællessystem
{
    public static class FactoryViewModels
    {
        // Initialize MainViewModel
        public static MainViewModel mvm = new MainViewModel();

        // Viewmodels

        public static AreaVM CreateAreaVM(Area area)
        {
            return new AreaVM(area);
        }

        public static FoodChoiceVM CreateFoodChoiceVM(FoodChoice foodChoice)
        {
            return new FoodChoiceVM(foodChoice);
        }

        public static MemberListVM CreateMemberListVM(MemberList memberList)
        {
            return new MemberListVM(memberList);
        }

        public static RoleVM CreateRoleVM(Role role)
        {
            return new RoleVM(role);
        }

        public static TicketTypeVM CreateTicketTypeVM(TicketType ticketType)
        {
            return new TicketTypeVM(ticketType);
        }

        // Collections
        public static ObservableCollection<AreaVM> CreateAreaVMs()
        {
            return new ObservableCollection<AreaVM>();
        }

        public static ObservableCollection<FoodChoiceVM> CreateFoodChoiceVMs()
        {
            return new ObservableCollection<FoodChoiceVM>();
        }

        public static ObservableCollection<MemberListVM> CreateMemberListVMs()
        {
            return new ObservableCollection<MemberListVM>();
        }

        public static ObservableCollection<RoleVM> CreateRoleVMs()
        {
            return new ObservableCollection<RoleVM>();
        }

        public static ObservableCollection<TicketChoiceVM> CreateTicketChoiceVMs()
        {
            return new ObservableCollection<TicketChoiceVM>() { new TicketChoiceVM("Medlemmer"), new TicketChoiceVM("Frivillige") };
        }

        public static ObservableCollection<TicketTypeVM> CreateTicketTypeVMs()
        {
            return new ObservableCollection<TicketTypeVM>();
        }
        // Handlers

        public static NewVolunteerApplicationHandler CreateNewVolunteerApplicationHandler()
        {
            return new NewVolunteerApplicationHandler();
        }

        public static PurchaseTicketHandler CreatePurchaseTicketHandler()
        {
            return new PurchaseTicketHandler();
        }

        public static ViewMemberListHandler CreateViewMemberListHandler()
        {
            return new ViewMemberListHandler();
        }

        public static VolunteerAcceptAreaHandler CreateVolunteerAcceptAreaHandler()
        {
            return new VolunteerAcceptAreaHandler();
        }
    }
}
