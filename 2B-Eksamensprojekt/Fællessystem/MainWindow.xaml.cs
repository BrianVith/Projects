using Fællessystem.Model.Enums;
using Fællessystem.View;
using Fællessystem.ViewModel;
using Fællessystem.ViewModel.EventArgs;
using System;
using System.Windows;
using System.Windows.Input;

namespace Fællessystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = FactoryViewModels.mvm;
            FactoryViewModels.mvm.NewVolunteerApplicationController.NewVolunteerApplicationRequested += NewVolunteerApplicationHandler;
            FactoryViewModels.mvm.VolunteerAcceptAreaController.NewVolunteerAcceptAreaRequested += NewVolunteerAcceptAreaHandler;
            FactoryViewModels.mvm.PurchaseTicketController.PurchaseTicketRequested += PurchaseTicketHandler;
        }

        private NewVolunteerApplicationEventArgs NewVolunteerApplicationHandler(object sender, NewVolunteerApplicationEventArgs args)
        {
            try
            {
                this.Hide();

                args = new NewVolunteerApplicationEventArgs();
                NewVolunteerApplicationWindow newVolunteerApplicationWindow = FactoryWindows.CreateNewVolunterrApplicationWindow();

                if ((bool)newVolunteerApplicationWindow.ShowDialog())
                {
                    if (newVolunteerApplicationWindow.cbUpDownFood.IsChecked.Value)
                    {
                        args.AreaList.Add(Areas.OpNedMad);
                        args.CommentList.Add(newVolunteerApplicationWindow.tbUpDownFood.Text);
                    }

                    if (newVolunteerApplicationWindow.cbKitchen.IsChecked.Value)
                    {
                        args.AreaList.Add(Areas.Køkken);
                        args.CommentList.Add(newVolunteerApplicationWindow.tbKitchen.Text);
                    }

                    if (newVolunteerApplicationWindow.cbBetaBar.IsChecked.Value)
                    {
                        args.AreaList.Add(Areas.BetaBar);
                        args.CommentList.Add(newVolunteerApplicationWindow.tbBetaBar.Text);
                    }

                    if (newVolunteerApplicationWindow.cbAlternaBar.IsChecked.Value)
                    {
                        args.AreaList.Add(Areas.AlternaBar);
                        args.CommentList.Add(newVolunteerApplicationWindow.tbAlternaBar.Text);  
                    }

                    return args;
                }
            }
            finally
            {
                this.Show();
            }
            return null;
        }

        private NewVolunteerAcceptAreaEventArgs NewVolunteerAcceptAreaHandler(object sender, NewVolunteerAcceptAreaEventArgs args)
        {
            try
            {
                this.Hide();

                args = new NewVolunteerAcceptAreaEventArgs();
                VolunteerAcceptAreaWindow newVolunteerAcceptAreaWindow = FactoryWindows.CreateVolunteerAcceptArea();

                if (newVolunteerAcceptAreaWindow.ShowDialog() ?? false)
                {
                    args.FoodChoice = ((FoodChoiceVM)newVolunteerAcceptAreaWindow.ComboFoodChoice.SelectedItem).FoodChoiceName;
                    args.Area = ((AreaVM)newVolunteerAcceptAreaWindow.AreaListView.SelectedItem).AreaName;
                    return args;
                }
            }
            finally
            {
                this.Show();
            }
            return null;
        }

        private PurchaseTicketEventArgs PurchaseTicketHandler(object sender, PurchaseTicketEventArgs args)
        {
            try
            {
                this.Hide();

                args = new PurchaseTicketEventArgs();
                PurchaseTicketWindow NewPurchaseTicketWindow = FactoryWindows.CreatePurchaseTicketWindow();

                if ((bool)NewPurchaseTicketWindow.ShowDialog())
                {
                    if (NewPurchaseTicketWindow.TaskKitchen.IsChecked.Value)
                    {
                        args.Task = (Tasks)Enum.Parse(typeof(Tasks), NewPurchaseTicketWindow.TaskKitchen.Content.ToString());
                    }
                    else if (NewPurchaseTicketWindow.TaskGarbage.IsChecked.Value)
                    {
                        args.Task = (Tasks)Enum.Parse(typeof(Tasks), NewPurchaseTicketWindow.TaskGarbage.Content.ToString());
                    }
                    else if (NewPurchaseTicketWindow.TaskDishes.IsChecked.Value)
                    {
                        args.Task = (Tasks)Enum.Parse(typeof(Tasks), NewPurchaseTicketWindow.TaskDishes.Content.ToString());
                    }
                    return args;
                }
            }
            finally
            {
                this.Show();
            }
            return null;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
