using Fællessystem.Handlers;
using Fællessystem.Model;
using Fællessystem.Persistence;
using Fællessystem.ViewModel.EventArgs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Fællessystem.Commands;
using Fællessystem.Model.Enums;

namespace Fællessystem.ViewModel
{
    public class MainViewModel 
    {
        // Observable collections
        public ObservableCollection<RoleVM> RoleVMs { get; set; }
        public ObservableCollection<TicketTypeVM> TicketTypeVMs { get; set; }
        public ObservableCollection<FoodChoiceVM> FoodChoiceVMs { get; set; }
        public Member SelectedMember { get; set; }

        // Handlers
        public NewVolunteerApplicationHandler NewVolunteerApplicationController { get; }
        public PurchaseTicketHandler PurchaseTicketController { get; }
        public ViewMemberListHandler ViewMemberListController { get; }
        public VolunteerAcceptAreaHandler VolunteerAcceptAreaController { get; }

        #region Commands
        public ICommand VolunteerCmd { get; } = FactoryCommands.CreateVolunteerCmd();
        public ICommand CloseCmd { get; } = FactoryCommands.CreateCloseCmd();
        public ICommand PurchaseTicketCmd { get; } = FactoryCommands.CreatePurchaseCmd();
        public ICommand ViewMemberListCmd { get; } = FactoryCommands.CreateViewMemberListCmd();
        #endregion

        public MainViewModel()
        {
            FoodChoiceVMs = FactoryViewModels.CreateFoodChoiceVMs();
            RoleVMs = FactoryViewModels.CreateRoleVMs();
            TicketTypeVMs = FactoryViewModels.CreateTicketTypeVMs();

            NewVolunteerApplicationController = FactoryViewModels.CreateNewVolunteerApplicationHandler();
            PurchaseTicketController = FactoryViewModels.CreatePurchaseTicketHandler();
            ViewMemberListController = FactoryViewModels.CreateViewMemberListHandler();
            VolunteerAcceptAreaController = FactoryViewModels.CreateVolunteerAcceptAreaHandler();

            SelectedMember = (Member)FactoryModels.CreateMember(12); // Test subject

            GetViewModelData();
        }

        // Initialize observable collections, to be delegated to handlers as needed
        private void GetViewModelData()
        {
            RoleVMs = FactoryRepositories.CreateinitializeMemberDataRepository().GetRoleVMs();
            FoodChoiceVMs = FactoryRepositories.CreateinitializeMemberDataRepository().GetFoodChoiceVMs();
            TicketTypeVMs = FactoryRepositories.CreateinitializeMemberDataRepository().GetTicketTypeVMs();
        }

        // Buy a ticket
        public void PurchaseTicket()
        {
            PurchaseTicketController.PurchaseTicket(SelectedMember, FoodChoiceVMs, TicketTypeVMs);
        }

        // Make an application for becoming volunteer 
        public void CreateNewVolunteerApplication()
        {
            NewVolunteerApplicationController.CreateNewVolunteerApplication(SelectedMember);
        }

        // Become volunteer on an area invited to
         public void AcceptVolunteerSpot()
        {
            VolunteerAcceptAreaController.AcceptVolunteerSpot(SelectedMember);
        }

        // Validates whether selected member has any free tickets
        public bool ValidateFreeTicket()
        {
            if(FactoryRepositories.CreateFreeTicketRepository().GetByID(SelectedMember.MemberID) != null)
                return true;
            
            return false;
        }

        // Checks wheteher the selected member has bought all 3 day-tickets or a partout ticket
        public bool ValidateTickets()
        {
            List<Ticket> tickets = FactoryRepositories.CreateTicketRepository().GetByID(SelectedMember.MemberID);
            if (tickets.Count == 0)
                return false;
            
            else if (tickets.Find(x => FactoryRepositories.CreateTicketTypeRepository().GetByID(x.TicketTypeID).TicketTypeName == TicketTypes.Partout) != null)
                return true;
            
            else if (tickets.Count == 3)
                return true;
            
            return false;
        }
    }
}
