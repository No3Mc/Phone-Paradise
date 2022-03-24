using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSSClasses;
using System;

namespace PhoneSystemTesting.Staff
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //test to see if it exsists
            Assert.IsNotNull(AStaff);
        }


        [TestMethod]
        public void StaffNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffEmailAddressOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AStaff.StaffEmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffEmailAddress, TestData);
        }

        [TestMethod]
        public void StaffPasswordOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AStaff.StaffPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffPassword, TestData);
        }

        [TestMethod]
        public void StaffPositionOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AStaff.StaffPosition = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffPosition, TestData);
        }

        [TestMethod]
        public void StaffTelephoneOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffTelephoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffTelephoneNo, TestData);
        }

    }
}
