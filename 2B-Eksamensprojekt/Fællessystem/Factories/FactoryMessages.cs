using System.Windows;

namespace Fællessystem
{
    public static class FactoryMessages
    {
        // Messages to user
        public static string VolunteerConfirmationText { get; } = "Du er nu frivillig hos Fællestival på området ";

        // Messagebox headers
        public static string VolunteerConfirmationBoxHeader { get; } = "Ansøgning sendt";

        public static void CreateMessageBox(string areaName)
        {
            MessageBox.Show($"{VolunteerConfirmationText}{areaName}", VolunteerConfirmationBoxHeader, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void CreateMessageBox(string message = "", string header = "")
        {
            MessageBox.Show(message, header, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
