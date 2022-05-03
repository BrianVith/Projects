using Fællessystem.Persistence;

namespace Fællessystem
{
    public static class FactoryRepositories
    {
        public static AreaRepository CreateAreaRepository()
        {
            return new AreaRepository();
        }

        public static FoodChoiceRepository CreateFoodChoiceRepository()
        {
            return new FoodChoiceRepository();
        }

        public static FreeTicketRepository CreateFreeTicketRepository()
        {
            return new FreeTicketRepository();
        }

        public static InitializeMemberDataRepository CreateinitializeMemberDataRepository()
        {
            return new InitializeMemberDataRepository();
        }

        public static MemberListRepository CreateMemberListRepository()
        {
            return new MemberListRepository();
        }

        public static RoleRepository CreateRoleRepository()
        {
            return new RoleRepository();
        }

        public static TaskRepository CreateTaskRepository()
        {
            return new TaskRepository();
        }

        public static TicketRepository CreateTicketRepository()
        {
            return new TicketRepository();
        }

        public static TicketTypeRepository CreateTicketTypeRepository()
        {
            return new TicketTypeRepository();
        }
        public static VolunteerApplicationRepository CreateVolunteerAplicationRepository()
        {
            return new VolunteerApplicationRepository();
        }

        public static VolunteerWaitingListRepository CreateVolunteerWaitingListRepository()
        {
            return new VolunteerWaitingListRepository();
        }
    }
}
