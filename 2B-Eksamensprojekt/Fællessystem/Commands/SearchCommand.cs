using Fællessystem.Handlers;
using System;
using System.Windows.Input;

namespace Fællessystem.Commands
{
    public class SearchCommand : ICommand
    {
        public event EventHandler CanExecuteChanged { add { } remove { } }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewMemberListHandler vmlHandler)
            {
                vmlHandler.ShowMemberList();
            }
        }
    }
}
