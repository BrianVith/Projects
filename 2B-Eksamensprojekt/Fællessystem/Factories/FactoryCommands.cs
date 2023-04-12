using Fællessystem.Commands;
using System.Windows.Input;

namespace Fællessystem
{
    public static class FactoryCommands
    {
        //Commands
        public static ICommand CreateVolunteerCmd()
        {
            return new VolunteerCommand();
        }

        public static ICommand CreateCloseCmd()
        {
            return new CloseCommand();
        }

        public static ICommand CreateConfirmCmd()
        {
            return new ConfirmCommand();
        }

        public static ICommand CreatePurchaseCmd()
        {
            return new PurchaseTicketCommand();
        }

        public static ICommand CreateViewMemberListCmd()
        {
            return new ViewMemberListCommand();
        }
    }
}
