using Fællessystem.View;
using System;
using System.Windows;
using System.Windows.Input;

namespace Fællessystem.Commands
{
    public class CloseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged { add { } remove { } }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewMemberListWindow vmlWindow)
            {
                App.Current.MainWindow.Show();
                vmlWindow.Close();
            }
            if (parameter is Window window)
            {
                window.Close();
            }
        }
    }
}
