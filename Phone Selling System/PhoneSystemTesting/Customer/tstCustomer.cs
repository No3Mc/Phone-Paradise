using PSSClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;




//Dbo.tblCustomer Values
//[CustID]
//[Address]
//[DOB]     
//[Name]  
//[Email] 
//[PhoneNo]
namespace PhoneSystemTesting
{
    [TestClass]
    public class tstCustomer
    {
        int CustID = 1;
        string Address = "aa";
        string DOB = "aa";
        string Name = "aa";
        string Email = "aa";
        string PhoneNo = "aa";

      


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustID, TestData);
        }


        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "abracadabra";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void DOBOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "abracadabra";
            //assign the data to the property
            ACustomer.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DOB, TestData);
        }

        [TestMethod]
        public void NameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "abracadabra";
            //assign the data to the property
            ACustomer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Name, TestData);
        }


        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "abracadabra";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void PhoneNoOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "abracadabra";
            //assign the data to the property
            ACustomer.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }



        //[CustID]
        //[Address]
        //[DOB]     
        //[Name]  
        //[Email] 
        //[PhoneNo]

        [TestMethod]
        public void TestCustIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustID = 1;
            Found = ACustomer.Find(CustID);
            if (ACustomer.CustID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustID = 1;
            Found = ACustomer.Find(CustID);
            if (ACustomer.Address != "abracadabra")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDOBFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustID = 1;
            Found = ACustomer.Find(CustID);
            if (ACustomer.DOB != "abracadabra")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustID = 1;
            Found = ACustomer.Find(CustID);
            if (ACustomer.Name != "abracadabra")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustID = 1;
            Found = ACustomer.Find(CustID);
            if (ACustomer.Email != "abracadabra")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNoFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustID = 1;
            Found = ACustomer.Find(CustID);
            if (ACustomer.PhoneNo != "abracadabra")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //[CustID]
        //[Address]
        //[DOB]     
        //[Name]  
        //[Email] 
        //[PhoneNo]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



















        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Address = "A"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Address = "Aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            //genarate 50 times letter A
            Address = Address.PadRight(49, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            //genarate 50 times letter A
            Address = Address.PadRight(50, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            //genarate 50 times letter A
            Address = Address.PadRight(25, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            //genarate 50 times letter A
            Address = Address.PadRight(51, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            //genarate 50 times letter A
            Address = Address.PadRight(500, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }









        public void DOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string DOB = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string DOB = "A"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string DOB = "Aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string DOB = "";
            //genarate 50 times letter A
            DOB = DOB.PadRight(49, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string DOB = "";
            //genarate 50 times letter A
            DOB = DOB.PadRight(50, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string DOB = "";
            //genarate 50 times letter A
            DOB = DOB.PadRight(25, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string DOB = "";
            //genarate 50 times letter A
            DOB = DOB.PadRight(51, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string DOB = "";
            //genarate 50 times letter A
            DOB = DOB.PadRight(500, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }













        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Name = "A"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Name = "Aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            //genarate 50 times letter A
            Name = Name.PadRight(49, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            //genarate 50 times letter A
            Name = Name.PadRight(50, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            //genarate 50 times letter A
            Name = Name.PadRight(25, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            //genarate 50 times letter A
            Name = Name.PadRight(51, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            //genarate 50 times letter A
            Name = Name.PadRight(500, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




















        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Email = "A"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Email = "Aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            //genarate 50 times letter A
            Email = Email.PadRight(49, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            //genarate 50 times letter A
            Email = Email.PadRight(50, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            //genarate 50 times letter A
            Email = Email.PadRight(25, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            //genarate 50 times letter A
            Email = Email.PadRight(51, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            //genarate 50 times letter A
            Email = Email.PadRight(500, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        public void PhoneNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "A"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "Aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "";
            //genarate 50 times letter A
            PhoneNo = PhoneNo.PadRight(49, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "";
            //genarate 50 times letter A
            PhoneNo = PhoneNo.PadRight(50, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "";
            //genarate 50 times letter A
            PhoneNo = PhoneNo.PadRight(25, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "";
            //genarate 50 times letter A
            PhoneNo = PhoneNo.PadRight(51, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "";
            //genarate 50 times letter A
            PhoneNo = PhoneNo.PadRight(500, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustID,  PhoneNo,  Address,  DOB,  Name,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
































    }
}
