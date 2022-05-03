using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fællessystem.View
{
    public partial class ViewMemberListWindow : Window
    {
        public ViewMemberListWindow()
        {
            InitializeComponent();
            DataContext = FactoryViewModels.mvm.ViewMemberListController;

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void ComboRoleType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboRoleType.SelectedIndex != -1)
            {
                ComboTicketFoodChoice.SelectedIndex = -1;
                ComboFoodChoice.SelectedIndex = -1;
            }
        }

        private void ComboTicketFoodChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboTicketFoodChoice.SelectedIndex != -1)
            {
                ComboRoleType.SelectedIndex = -1;
                ComboFoodChoice.SelectedIndex = -1;
            }

        }

        private void dgMemberList_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            ComboTicketFoodChoice.SelectedIndex = -1;
            ComboFoodChoice.SelectedIndex = -1;
            ComboRoleType.SelectedIndex = -1;
            FactoryViewModels.mvm.ViewMemberListController.ClearAllMemberVMs();
        }

        private void ComboFoodChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboFoodChoice.SelectedIndex != -1)
            {
                ComboRoleType.SelectedIndex = -1;
                ComboTicketFoodChoice.SelectedIndex = -1;
            }
        }
    }
}
