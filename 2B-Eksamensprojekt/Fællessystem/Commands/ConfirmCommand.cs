using Fællessystem.View;
using Fællessystem.ViewModel;
using System;
using System.Windows;
using System.Windows.Input;

namespace Fællessystem.Commands
{
    public class ConfirmCommand : ICommand
    {
        
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (parameter is VolunteerAcceptAreaWindow vaaWindow)
            {
                if (vaaWindow.AreaListView.SelectedItem != null && (((FoodChoiceVM)vaaWindow.ComboFoodChoice.SelectedItem).FoodChoiceName) != default)
                    return true;
            }

            else if (parameter is NewVolunteerApplicationWindow nvaWindow)
            {
                if (nvaWindow.cbAllAreas.IsChecked == false)
                    return false;

                else
                    return true;
            }

            else if (parameter is PurchaseTicketWindow ptWindow)
            {
                if (ptWindow.ComboTicketType.SelectedItem != null && ptWindow.ComboFoodChoice.SelectedItem != null)
                    return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            if (parameter is NewVolunteerApplicationWindow nvaWindow)
                nvaWindow.DialogResult = true;

            else if (parameter is VolunteerAcceptAreaWindow vaaWindow)
                vaaWindow.DialogResult = true;

            else if (parameter is PurchaseTicketWindow ptWindow)
                ptWindow.DialogResult = true;
        }
    }
}
