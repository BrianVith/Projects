using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fællessystem.Model;
using Fællessystem.Persistence;
using System.Collections.Generic;
using Fællessystem.Model.Enums;
using Fællessystem.ViewModel;
using System;

namespace UnitTestFællessystem
{
    [TestClass]
    public class ApplyForVolunteer
    {
        //Arrange
        Areas areas;
        MainViewModel mvm;
        VolunteerApplication volunteerApplication;
        Member m1;
        MemberRepository memberRepo;
        VolunteerApplicationRepository volunteerApplicationRepo;
        AreaVolunteerApplicationRepository areaVolunteerApplicationRepo;
        List<Areas> areaList;


        [TestInitialize]
        public void Init()
        {
            areas = new Areas();
            m1 = new Member() { MemberName = "Nick Noob", Email = "NickNoob@mail.dk", PhoneNumber = "12344321", ActiveID = 1 };
            mvm = new MainViewModel();
            volunteerApplication = new VolunteerApplication(12, areaList, "Jeg har barerfaring");
            memberRepo = new MemberRepository();
            volunteerApplicationRepo = new VolunteerApplicationRepository();
            areaVolunteerApplicationRepo = new AreaVolunteerApplicationRepository();
            areaList = new List<Areas>() { Areas.BetaBar, Areas.Kitchen };
        }

        [TestMethod]
        public void InsertMemberIntoDatabase()
        {
            //Act
            int rowsAffected = memberRepo.Add(m1);

            //Assert
            Assert.AreEqual(1, rowsAffected);
        }


        [TestMethod]
        public void InsertVolunteerApplicationIntoDatabase()
        {
            //Act
            int rowsAffected = volunteerApplicationRepo.Add(volunteerApplication);
            //Assert
            Assert.AreEqual(1, rowsAffected);
        }

        [TestMethod]
        public void GetVolunteerApplicationIDWithGetByMemberIDMethod()
        {
            //Arrange
            int memberID = 12;
            //Act
            int AppID = volunteerApplicationRepo.GetByMemberId(memberID);
            //Assert
            Assert.AreEqual(4, AppID);
        }

        [TestMethod]
        public void SaveAreaIDAndVolunteerApplicationIDToDatabaseLinkingTable()
        {
            //Act
            int volunteerApplicationID = 4;
            //Assert
            foreach (Areas area in areaList)
            {
                areaVolunteerApplicationRepo.Add((int)area, (int)volunteerApplicationID);   
            }
        }
    }
}
