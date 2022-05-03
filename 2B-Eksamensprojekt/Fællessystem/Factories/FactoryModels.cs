using Fællessystem.Model;
using Fællessystem.Model.Enums;
using System.Collections.Generic;

namespace Fællessystem
{
    public static class FactoryModels
    {

        //Models
        public static IArea CreateArea(int? areaID = 0, Areas areaName = 0)
        {
            return new Area(areaID, areaName);
        }
        public static FoodChoice CreateFoodchoice(int? foodChoiceID = 0, FoodChoices foodChoiceName = 0)
        {
            return new FoodChoice(foodChoiceID, foodChoiceName);
        }

        public static ITicket CreateFreeTicket()
        {
            return new FreeTicket();
        }

        public static ITicket CreateFreeTicket(int? memberID, int? areaID, int? foodChoiceID)
        {
            return new FreeTicket(memberID, areaID, foodChoiceID);
        }

        public static TicketType CreateTicketType()
        {
            return new TicketType();
        }

        public static IMember CreateMember()
        {
            return new Member();
        }

        public static IMember CreateMember(int? memberID)
        {
            return new Member(memberID);
        }

        public static MemberList CreateMemberList(string memberName = "", string email = "", string phoneNumber = "", string roleName = "", int? ticketID = null, int? freeTicketID = null, FoodChoices foodChoiceName = 0, TicketTypes ticketTypeName = 0)
        {
            return new MemberList(memberName, email, phoneNumber, roleName, ticketID, freeTicketID, foodChoiceName, ticketTypeName);
        }

        public static ITicket CreateTicket(int? memberID = 0, TicketTypes ticketType = 0, FoodChoices foodChoice = 0, int? ticketTypeID = -1)
        {
            return new Ticket(memberID, ticketType, foodChoice, ticketTypeID);
        }

        public static VolunteerApplication CreateVolunteerApplication(int? memberID, Areas area, string comment)
        {
            return new VolunteerApplication(memberID, area, comment);
        }

        // Lists

        public static List<MemberList> CreateListOfMemberList()
        {
            return new List<MemberList>();
        }

        public static List<FoodChoice> CreateListOfFoodchoice()
        {
            return new List<FoodChoice>();
        }
        public static List<Role> CreateListOfRole()
        {
            return new List<Role>();
        }
        public static List<Area> CreateListOfArea()
        {
            return new List<Area>();
        }
        public static List<TicketType> CreateListOfTicketType()
        {
            return new List<TicketType>();
        }
        public static List<Ticket> CreateListOfTicket()
        {
            return new List<Ticket>();
        }
    }
}
