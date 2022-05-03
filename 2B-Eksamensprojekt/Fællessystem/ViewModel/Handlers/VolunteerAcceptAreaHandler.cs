using Fællessystem.Model;
using Fællessystem.Persistence;
using Fællessystem.ViewModel;
using Fællessystem.ViewModel.EventArgs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Fællessystem.Handlers
{
    public delegate NewVolunteerAcceptAreaEventArgs NewVolunteerAcceptAreaEventHandler(object sender, NewVolunteerAcceptAreaEventArgs args);
    public class VolunteerAcceptAreaHandler 
    {
        public event NewVolunteerAcceptAreaEventHandler NewVolunteerAcceptAreaRequested;
        public ICommand CloseCmd { get; } = FactoryCommands.CreateCloseCmd();
        public ICommand ConfirmCmd { get; } = FactoryCommands.CreateConfirmCmd();

        private AreaRepository areaRepo;
        private FoodChoiceRepository foodChoicesRepo;
        private FreeTicketRepository freeTicketRepo;
        private TicketRepository ticketRepo;
        private VolunteerWaitingListRepository volunteerWaitingListRepo;

        public ObservableCollection<AreaVM> AreaListVMs { get; set; }
        public ObservableCollection<FoodChoiceVM> FoodChoiceVMs { get; set; }

        public VolunteerAcceptAreaHandler()
        {
            areaRepo = FactoryRepositories.CreateAreaRepository();
            foodChoicesRepo = FactoryRepositories.CreateFoodChoiceRepository();
            freeTicketRepo = FactoryRepositories.CreateFreeTicketRepository();
            ticketRepo = FactoryRepositories.CreateTicketRepository();
            volunteerWaitingListRepo = FactoryRepositories.CreateVolunteerWaitingListRepository();

            AreaListVMs = FactoryViewModels.CreateAreaVMs();
            FoodChoiceVMs = FactoryViewModels.CreateFoodChoiceVMs();
        }
        public void AcceptVolunteerSpot(Member member)
        {
            NewVolunteerAcceptAreaEventArgs e = OnNewVolunteerAcceptAreaRequested();
            if (e != null)
            {
                FreeTicket freeTicket = (FreeTicket)FactoryModels.CreateFreeTicket(member.MemberID, areaRepo.GetID(e.Area), foodChoicesRepo.GetID(e.FoodChoice));

                _ = volunteerWaitingListRepo.AcceptVolunteerAgreement(member.MemberID);

                freeTicketRepo.Add(freeTicket);

                FactoryMessages.CreateMessageBox(e.Area.ToString());
            }
        }

        public void CheckVolunteerInvitations(int? memberID)
        {
            try
            {
                AreaListVMs.Clear();

                foreach (Area area in volunteerWaitingListRepo.VerifyToWaitingList(memberID))
                {
                    AreaVM areaVM = FactoryViewModels.CreateAreaVM(area);
                    AreaListVMs.Add(areaVM);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected NewVolunteerAcceptAreaEventArgs OnNewVolunteerAcceptAreaRequested()
        {
            NewVolunteerAcceptAreaEventArgs result = null; //Creating result
            NewVolunteerAcceptAreaEventHandler newVolunteerAcceptAreaRequested = NewVolunteerAcceptAreaRequested;  //

            if (NewVolunteerAcceptAreaRequested != null)
            {
                NewVolunteerAcceptAreaEventArgs args = null; //Creating args
                result = newVolunteerAcceptAreaRequested(this, args);
            }
            return result;
        }
    }
}
