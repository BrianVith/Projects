using Fællessystem.Model;
using Fællessystem.Persistence;
using Fællessystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Fællessystem.Commands;

namespace Fællessystem.Handlers
{
    public class ViewMemberListHandler : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private MemberListRepository memberListRepo;

        public ICommand CloseCmd { get; } = FactoryCommands.CreateCloseCmd();
        public ICommand SearchCmd { get; } = new SearchCommand();

        public ObservableCollection<MemberListVM> MemberListVMs { get; set; }
        public ObservableCollection<RoleVM> RoleVMs { get; set; }
        public ObservableCollection<TicketChoiceVM> TicketChoiceVMs { get; set; }
        public ObservableCollection<FoodChoiceVM> FoodChoiceVMs { get; set; }

        private RoleVM selectedRole;
        public RoleVM SelectedRole
        {
            get { return selectedRole; }
            set { selectedRole = value; OnPropertyChanged("SelectedRole"); }
        }

        private TicketChoiceVM selectedTicketChoice;
        public TicketChoiceVM SelectedTicketChoice
        {
            get { return selectedTicketChoice; }
            set { selectedTicketChoice = value; OnPropertyChanged("SelectedTicketChoice"); }
        }

        private FoodChoiceVM selectedFoodChoice;
        public FoodChoiceVM SelectedFoodChoice
        {
            get { return selectedFoodChoice; }
            set { selectedFoodChoice = value; OnPropertyChanged("SelectedFoodChoice"); }
        }

        public ViewMemberListHandler()
        {
            memberListRepo = FactoryRepositories.CreateMemberListRepository();

            MemberListVMs = FactoryViewModels.CreateMemberListVMs();
            FoodChoiceVMs = FactoryViewModels.CreateFoodChoiceVMs();
            RoleVMs = FactoryViewModels.CreateRoleVMs();
            TicketChoiceVMs = FactoryViewModels.CreateTicketChoiceVMs();
        }

        // Shows a list of based on the desired critera chosen in the View
        public void ShowMemberList()
        {
            MemberListVMs = GetAllMembers();
            IEnumerable<MemberListVM> query;
            query = MemberListVMs.GroupBy(x => x.MemberName).Select(m => m.First());

            if (SelectedRole != null)
            {
                query = (from m in MemberListVMs where m.RoleName == SelectedRole.RoleName select m).ToList();
            }
            else if (SelectedFoodChoice != null)
            {
                query = (from m in MemberListVMs where m.FoodChoiceName == SelectedFoodChoice.FoodChoiceName select m).GroupBy(x => x.TicketID).Select(m => m.First()).ToList();
            }
            else if (SelectedTicketChoice != null)
            {
                if (SelectedTicketChoice.TicketChoiceName == "Medlemmer")
                {
                    query = (from m in MemberListVMs where m.TicketID != null select m).GroupBy(x => x.TicketID).Select(m => m.First()).ToList();

                }
                else if (SelectedTicketChoice.TicketChoiceName == "Frivillige")
                {
                    query = (from m in MemberListVMs where m.FreeTicketID != null select m).GroupBy(x => x.FreeTicketID).Select(m => m.First()).ToList();
                }
            }

            MemberListVMs.Clear();

            foreach (var item in query)
            {
                MemberListVMs.Add(item);
            }
        }

        private ObservableCollection<MemberListVM> GetAllMembers()
        {
            MemberListVMs.Clear();
            foreach (MemberList memberRole in memberListRepo.GetAll())
            {
                MemberListVMs.Add(FactoryViewModels.CreateMemberListVM(memberRole));
            }

            return MemberListVMs;
        }
        public void ClearAllMemberVMs()
        {
            MemberListVMs.Clear();
        }

        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
