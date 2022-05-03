using Fællessystem.Model.Enums;
using System;
using System.Windows;
using System.Windows.Input;

namespace Fællessystem.View
{
    public partial class PurchaseTicketWindow : Window
    {
        public PurchaseTicketWindow()
        {
            InitializeComponent();
            DataContext = FactoryViewModels.mvm.PurchaseTicketController;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
