using Fællessystem.Model;
using Fællessystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Fællessystem.Persistence
{
    public class InitializeMemberDataRepository
    {
        public ObservableCollection<RoleVM> GetRoleVMs()
        {
            ObservableCollection<RoleVM> RoleVMs = FactoryViewModels.CreateRoleVMs();
            foreach (Role role in FactoryRepositories.CreateRoleRepository().GetAll())
            {
                RoleVMs.Add(FactoryViewModels.CreateRoleVM(role));
            }
            return RoleVMs;
        }

        public ObservableCollection<FoodChoiceVM> GetFoodChoiceVMs()
        {
            ObservableCollection<FoodChoiceVM> FoodChoiceVMs = FactoryViewModels.CreateFoodChoiceVMs();
            foreach (FoodChoice foodChoice in FactoryRepositories.CreateFoodChoiceRepository().GetAll())
            {
                FoodChoiceVMs.Add(FactoryViewModels.CreateFoodChoiceVM(foodChoice));
            }
            return FoodChoiceVMs;
        }

        public ObservableCollection<TicketTypeVM> GetTicketTypeVMs()
        {
            ObservableCollection<TicketTypeVM> TicketTypeVMs = FactoryViewModels.CreateTicketTypeVMs();
            foreach (TicketType ticketType in FactoryRepositories.CreateTicketTypeRepository().GetAll())
            {
                TicketTypeVMs.Add(FactoryViewModels.CreateTicketTypeVM(ticketType));
            }
            return TicketTypeVMs;
        }
    }
}
