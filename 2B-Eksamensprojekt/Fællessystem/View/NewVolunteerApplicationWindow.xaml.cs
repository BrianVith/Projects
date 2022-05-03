using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Fællessystem.View
{
    public partial class NewVolunteerApplicationWindow : Window
    {
        public NewVolunteerApplicationWindow()
        {
            InitializeComponent();
            DataContext = FactoryViewModels.mvm.NewVolunteerApplicationController;
        }

        private void cbAllAreasSelected_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newValue = (cbAllAreas.IsChecked == true);
            cbUpDownFood.IsChecked = newValue;
            cbKitchen.IsChecked = newValue;
            cbBetaBar.IsChecked = newValue;
            cbAlternaBar.IsChecked = newValue;
        }
        private void cbAreaSelection_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllAreas.IsChecked = null;
            if ((cbUpDownFood.IsChecked == true) && (cbKitchen.IsChecked == true) && (cbBetaBar.IsChecked == true) && (cbAlternaBar.IsChecked == true))
                cbAllAreas.IsChecked = true;
            if ((cbUpDownFood.IsChecked == false) && (cbKitchen.IsChecked == false) && (cbBetaBar.IsChecked == false) && (cbAlternaBar.IsChecked == false))
                cbAllAreas.IsChecked = false;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text.Length < 24 || ((TextBox)sender).Text.Contains("Skriv erfaring og kommentar her!") == true)
            {
                MessageBox.Show("Du skal skrive min. 25 tegn.");
            }
        }

        private void tbComment_GotMouseCapture(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "Skriv erfaring og kommentar her!")
                ((TextBox)sender).SelectAll();
        }

        private void TextBox_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (((TextBox)sender).IsMouseDirectlyOver == true)
            {
                if (((TextBox)sender).Text.Length >= 25)
                    ((TextBox)sender).BorderBrush = Brushes.Green;
            }
        }
    }
}
