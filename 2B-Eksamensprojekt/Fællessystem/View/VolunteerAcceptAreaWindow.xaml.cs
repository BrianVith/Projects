using System.Windows;
using System.Windows.Input;

namespace Fællessystem.View
{
    public partial class VolunteerAcceptAreaWindow : Window
    {
        public VolunteerAcceptAreaWindow()
        {
            InitializeComponent();
            DataContext = FactoryViewModels.mvm.VolunteerAcceptAreaController;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
