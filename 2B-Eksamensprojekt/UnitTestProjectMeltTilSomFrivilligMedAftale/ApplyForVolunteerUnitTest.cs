using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fællessystem.Model;
using Fællessystem.Persistence;
using System.Collections.Generic;
using Fællessystem.Model.Enums;
using Fællessystem.ViewModel;
using System;

namespace FællessystemUnitTest
{
    [TestClass]
    public class ApplyForVolunteerUnitTest
    {
        //Arrange
        VolunteerApplication volunteerApplication;
        Member m1;
        VolunteerApplicationRepository volunteerApplicationRepo;
        Areas area;

        [TestInitialize]
        public void Init()
        {
            m1 = new Member(13);
            area = Areas.BetaBar;
            volunteerApplicationRepo = new VolunteerApplicationRepository();
            volunteerApplication = new VolunteerApplication(m1.MemberID, area, "Jeg har barerfaring, så derfor skal i vælge mig");
        }

        [TestMethod]
        public void InsertVolunteerApplicationIntoDatabase()
        {
            //Act
            int rowsAffected = volunteerApplicationRepo.Add(volunteerApplication);
            //Assert
            Assert.AreEqual(1, rowsAffected);
        }
    }
}