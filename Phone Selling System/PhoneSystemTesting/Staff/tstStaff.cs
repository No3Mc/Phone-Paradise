using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSSClasses;
using System;

namespace PhoneSystemTesting.Staff
{
    [TestClass]
    public class tstStaff
    {
        String StaffName = "cf";
        String StaffEmailAddress = "cf";
        String StaffPassword = "cf";
        String StaffPosition = "cf";
        String StaffTelephoneNo = "cf";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //test to see if it exsists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(StaffEmailAddress, StaffName, StaffPassword, StaffPosition, StaffTelephoneNo);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffNoOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the staff
            Int32 TestData = 1;
            //assign the data to the staff
            AStaff.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffNo, TestData);
        }

        [TestMethod]
        public void StaffNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the staff
            string TestData = "Steve Greggers";
            //assign the data to the staff
            AStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffEmailAddressOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the staff
            string TestData = "SteveGreggers@Gmail.com";
            //assign the data to the staff
            AStaff.StaffEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffPasswordOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the staff
            string TestData = "Julian20";
            //assign the data to the staff
            AStaff.StaffPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffPassword, TestData);
        }

        [TestMethod]
        public void StaffPositionOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the staff
            string TestData = "Worker";
            //assign the data to the staff
            AStaff.StaffPosition = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffPosition, TestData);
        }

        [TestMethod]
        public void StaffTelephoneOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the staff
            string TestData = "02476890768";
            //assign the data to the staff
            AStaff.StaffTelephoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffTelephoneNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the Staff Name
            if (AStaff.StaffNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the staff
            if (AStaff.StaffEmail != "SteveGreggers@Gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the Staff
            if (AStaff.StaffName != "Steve Greggers")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the staff
            if (AStaff.StaffPassword != "Julian20")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPositionFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the staff
            if (AStaff.StaffPosition != "Worker")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTelephoneFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the staff
            if (AStaff.StaffTelephoneNo != "02476890768")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
