using Fællessystem.ViewModel;
using System;
using System.Windows.Input;

namespace Fællessystem.Commands
{
    public class VolunteerCommand : ICommand
    {
        public event EventHandler CanExecuteChanged { add { } remove { } }

        public bool CanExecute(object parameter)
        {
            if (FactoryViewModels.mvm.ValidateFreeTicket() || FactoryRepositories.CreateTicketRepository().GetByID(FactoryViewModels.mvm.SelectedMember.MemberID).Count != 0)
            {
                return false;
            }
            return true;   
        }

        public void Execute(object parameter)
        {
            if (parameter is MainViewModel mvm)
            {
                try
                {
                    mvm.VolunteerAcceptAreaController.CheckVolunteerInvitations(mvm.SelectedMember.MemberID);
                }
                catch (Exception)
                {
                    throw;
                }

                if (mvm.VolunteerAcceptAreaController.AreaListVMs.Count != 0)
                {
                    FactoryViewModels.mvm.VolunteerAcceptAreaController.FoodChoiceVMs =  FactoryViewModels.mvm.FoodChoiceVMs;
                    mvm.AcceptVolunteerSpot();
                }
                else
                {
                    mvm.CreateNewVolunteerApplication();
                }
            }
        }
    }
}
