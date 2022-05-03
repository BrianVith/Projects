//using Fællessystem.Model;
//using Fællessystem.Persistence;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace FællessystemUnitTest
//{
//    [TestClass]
//    public class SeListeAfMedlemmerUnitTest
//    {
//        MemberListRepository memberListRepo;
//        List<MemberFoodChoice> memberFoodList;
//        List<VolunteerFoodChoice> volunteerFoodList;

//        [TestInitialize]
//        public void Init()
//        {
//            memberListRepo = new MemberListRepository();
//            memberFoodList = new List<MemberFoodChoice>();
//            volunteerFoodList = new List<VolunteerFoodChoice>();
//        }

//        [TestMethod]
//        public void GetMemberFoodchoicesTest()
//        {
//            memberFoodList = memberListRepo.GetMemberFoodchoices();
//            Assert.AreEqual(4, memberFoodList.Count);
//        }

//        [TestMethod]
//        public void GetVolunteerFoodchoicesTest()
//        {
//            volunteerFoodList = memberListRepo.GetVolunteerFoodchoices();
//            Assert.AreEqual(2, volunteerFoodList.Count);
//        }
//    }
//}
