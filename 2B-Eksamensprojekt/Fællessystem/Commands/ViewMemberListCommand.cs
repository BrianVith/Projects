using Fællessystem.ViewModel;
using System;
using System.Windows.Input;

namespace Fællessystem.Commands
{
    public class ViewMemberListCommand : ICommand
    {
        public event EventHandler CanExecuteChanged { add { } remove { } }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is MainWindow mainWindow)
            {
                FactoryViewModels.mvm.ViewMemberListController.RoleVMs = FactoryViewModels.mvm.RoleVMs;
                FactoryViewModels.mvm.ViewMemberListController.FoodChoiceVMs = FactoryViewModels.mvm.FoodChoiceVMs;

                FactoryWindows.CreateViewMemberListWindow().Show();
                mainWindow.Hide();
            }
        }
    }
}
