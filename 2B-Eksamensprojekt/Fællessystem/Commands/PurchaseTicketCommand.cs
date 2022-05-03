using Fællessystem.Model;
using Fællessystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Fællessystem.Commands
{
    public class PurchaseTicketCommand : ICommand
    {
        public event EventHandler CanExecuteChanged { add { } remove { } }

        public bool CanExecute(object parameter)
        {
            if (FactoryViewModels.mvm.ValidateFreeTicket() || FactoryViewModels.mvm.ValidateTickets())
            {
                return false;
            }
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is MainViewModel mvm)
            {
                mvm.PurchaseTicket();
            }
        }
    }
}
