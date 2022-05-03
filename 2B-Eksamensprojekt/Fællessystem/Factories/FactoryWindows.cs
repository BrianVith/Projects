using Fællessystem.View;
using System.Windows;

namespace Fællessystem
{
    public static class FactoryWindows
    {
        public static Window CreateMainWindow()
        {
            return new MainWindow();
        }

        public static VolunteerAcceptAreaWindow CreateVolunteerAcceptArea()
        {
            return new VolunteerAcceptAreaWindow();
        }

        public static NewVolunteerApplicationWindow CreateNewVolunterrApplicationWindow()
        {
            return new NewVolunteerApplicationWindow();
        }

        public static PurchaseTicketWindow CreatePurchaseTicketWindow()
        {
            return new PurchaseTicketWindow();
        }
        public static ViewMemberListWindow CreateViewMemberListWindow()
        {
            return new ViewMemberListWindow();
        }
    }
}
