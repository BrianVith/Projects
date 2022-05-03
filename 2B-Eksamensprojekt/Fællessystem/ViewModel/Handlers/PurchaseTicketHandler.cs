using Fællessystem.Model;
using Fællessystem.Model.Enums;
using Fællessystem.Persistence;
using Fællessystem.ViewModel;
using Fællessystem.ViewModel.EventArgs;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Fællessystem.Handlers
{
    public delegate PurchaseTicketEventArgs PurchaseTicketEventHandler(object sender, PurchaseTicketEventArgs args);
    public class PurchaseTicketHandler : INotifyPropertyChanged
    {

        public ICommand ConfirmCmd { get; } = FactoryCommands.CreateConfirmCmd();

        public event PurchaseTicketEventHandler PurchaseTicketRequested;
        public event PropertyChangedEventHandler PropertyChanged;

        private FoodChoiceRepository foodChoicesRepo;
        private TicketTypeRepository ticketTypeRepo;
        private TicketRepository ticketRepo;
        private TaskRepository taskRepo;

        public ObservableCollection<FoodChoiceVM> FoodChoiceVMs { get; set; }
        public ObservableCollection<TicketTypeVM> TicketTypeVMs { get; set; }

        private FoodChoiceVM selectedFoodChoice;
        public FoodChoiceVM SelectedFoodChoice
        {
            get { return selectedFoodChoice; }
            set { selectedFoodChoice = value; OnPropertyChanged("SelectedFoodChoice"); }
        }

        private TicketTypeVM selectedTicketType;
        public TicketTypeVM SelectedTicketType
        {
            get { return selectedTicketType; }
            set { selectedTicketType = value; OnPropertyChanged("SelectedTicketType"); }
        }

        public PurchaseTicketHandler()
        {
            foodChoicesRepo = FactoryRepositories.CreateFoodChoiceRepository();
            ticketTypeRepo = FactoryRepositories.CreateTicketTypeRepository();
            ticketRepo = FactoryRepositories.CreateTicketRepository();
            taskRepo = FactoryRepositories.CreateTaskRepository();

            FoodChoiceVMs = FactoryViewModels.CreateFoodChoiceVMs();
            TicketTypeVMs = FactoryViewModels.CreateTicketTypeVMs();
        }

        // Creates a Ticket object with TicketType, Task, and FoodChoice, chosen by the user in the View
        public bool PurchaseTicket(Member member, ObservableCollection<FoodChoiceVM> foodChoiceVMs, ObservableCollection<TicketTypeVM> ticketTypeVMs)
        {
            FoodChoiceVMs = foodChoiceVMs;
            TicketTypeVMs = new ObservableCollection<TicketTypeVM> (ticketTypeVMs);
            UpdateTicketTypeVMs();

            PurchaseTicketEventArgs e = OnPurchaseTicketRequested();
            if (e != null)
            {
                ITicket iticket = FactoryModels.CreateTicket(member.MemberID, SelectedTicketType.TicketTypeName, SelectedFoodChoice.FoodChoiceName);

                if (iticket is Ticket ticket)
                {
                    ticket.FoodChoiceID = foodChoicesRepo.GetID(SelectedFoodChoice.FoodChoiceName);
                    ticket.TicketTypeID = ticketTypeRepo.GetID(SelectedTicketType.TicketTypeName);
                    ticket.TaskID = taskRepo.GetID(e.Task);
                    ticket.MemberID = member.MemberID;
                }

                _ = ticketRepo.Add(iticket);

                FactoryMessages.CreateMessageBox("Tak for køb af billet til Fællestival", "Billet købt");

                return true;
            }
            return false;
        }

        private void UpdateTicketTypeVMs()
        {
            List<Ticket> MemberTickets = FactoryRepositories.CreateTicketRepository().GetByID(FactoryViewModels.mvm.SelectedMember.MemberID);

            // Remove Partout ticket if any other kind of ticket is bought
            if (MemberTickets.Count != 0)
            {
                TicketTypeVMs.RemoveAt(TicketTypeVMs.Count-1);
            }

            // Removes tickets, so only tickets not bought by member is shown
            foreach (Ticket ticket in MemberTickets)
            {
                for (int i = 0; i < TicketTypeVMs.Count; i++)
                {
                    if (TicketTypeVMs[i].TicketTypeID == ticket.TicketTypeID)
                    {
                        TicketTypeVMs.Remove(TicketTypeVMs[i]);
                    }
                }
            }
        }

        protected PurchaseTicketEventArgs OnPurchaseTicketRequested()
        {
            PurchaseTicketEventArgs result = null; //Creating result
            PurchaseTicketEventHandler purchaseTicketRequested = PurchaseTicketRequested;  //

            if (PurchaseTicketRequested != null)
            {
                PurchaseTicketEventArgs args = null; //Creating args
                result = purchaseTicketRequested(this, args);
            }
            return result;
        }

        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
