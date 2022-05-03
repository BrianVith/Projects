//using Fællessystem.Persistence;
//using Fællessystem.ViewModel;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace FællessystemUnitTest
//{
//    [TestClass]
//    public class MeldTilSomFrivilligUnitTest
//    {
//        //Arrange
//        MainViewModel mvm;
//        VolunteerWaitingListRepository volunteerWaitingListRepo;
//        int selectedMemberID;

//        [TestInitialize]
//        public void Init()
//        {
//            mvm = new MainViewModel();
//            volunteerWaitingListRepo = new VolunteerWaitingListRepository();
//            //mvm.volunteerWaitingListRepo.Create(6, 1);
//            //mvm.volunteerWaitingListRepo.Create(6, 2);
//            //mvm.volunteerWaitingListRepo.Create(6, 3);
//            selectedMemberID = mvm.SelectedMember.MemberID;
//        }

//        [TestMethod]
//        public void CheckAreaList()
//        {
//            //Arrange
//            volunteerWaitingListRepo.Create(selectedMemberID, 1);
//            volunteerWaitingListRepo.Create(selectedMemberID, 2);
//            volunteerWaitingListRepo.Create(selectedMemberID, 3);

//            //Act
//            mvm.CheckVolunteerInvitations(selectedMemberID);

//            //Assert
//            Assert.AreEqual("OpNedMad", mvm.AreaList[0]);
//            Assert.AreEqual("Køkken", mvm.AreaList[1]);
//            Assert.AreEqual("BetaBar", mvm.AreaList[2]);

//            volunteerWaitingListRepo.AcceptVolunteerAgreement(selectedMemberID);
//        }

//        [TestMethod]
//        public void AcceptAgreement()
//        {
//            //Arrange
//            volunteerWaitingListRepo.Create(selectedMemberID, 1);
//            volunteerWaitingListRepo.Create(selectedMemberID, 2);
//            volunteerWaitingListRepo.Create(selectedMemberID, 3);

//            //Act
//            int rowsAffected = volunteerWaitingListRepo.AcceptVolunteerAgreement(selectedMemberID);
//            volunteerWaitingListRepo.VerifyToWaitingList(selectedMemberID);

//            //Assert
//            Assert.AreEqual(0, mvm.AreaList.Count);
//            Assert.AreEqual(3, rowsAffected);

//        }

//        //[TestMethod]
//        //public void MakeFreeTicket()
//        //{
//        //    //Act
//        //    string foodChoice = "Meat"; // enum med ID 1 i db
//        //    string area = "OpNedMad"; // område med ID 1 i db

//        //    mvm.FreeTicketRepo.Add(mvm.FoodChoicesRepo.GetID(foodChoice), mvm.AreaRepo.GetID(area), selectedMemberID);

//        //    FreeTicket ticket = mvm.FreeTicketRepo.GetById(selectedMemberID);

//        //    //Assert
//        //    Assert.AreEqual(selectedMemberID, ticket.MemberID);
//        //    Assert.AreEqual(1, ticket.FoodChoiceID);
//        //    Assert.AreEqual(1, ticket.AreaID);
//        //    Assert.AreEqual(FoodChoices.Meat, ticket.FoodChoice);

//        //    mvm.FreeTicketRepo.DeleteID(selectedMemberID);
//        //}

//        //[TestMethod]
//        //public void GetFoodChoice()
//        //{
//        //    //Act
//        //    string foodChoice1 = "Meat"; // enum med ID 1 i db 
//        //    string foodChoice2 = "Vegetarian"; // enum med ID 2 i db
//        //    string foodChoice3 = "Vegan"; // enum med ID 3 i db 

//        //    int ID1 = mvm.FoodChoicesRepo.GetID(foodChoice1);
//        //    int ID2 = mvm.FoodChoicesRepo.GetID(foodChoice2);
//        //    int ID3 = mvm.FoodChoicesRepo.GetID(foodChoice3);

//        //    //Assert
//        //    Assert.AreEqual(1, ID1);
//        //    Assert.AreEqual(2, ID2);
//        //    Assert.AreEqual(3, ID3);

//        //}
//    }
//}
