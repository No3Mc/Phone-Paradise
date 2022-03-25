using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PSSClasses;
using System.Collections.Generic;


namespace PhoneSystemTesting
{
    [TestClass]
    public class tstSupplier
    {
       

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(aSupplier);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //Create some test data to assign to the property
            string TestData = "16, Barkley Street";
            //assign the data to the property
            aSupplier.Address = TestData;
            //test to see that it exists
            Assert.AreEqual(aSupplier.Address, TestData);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //Create some test data to assign to the property
            int TestData = 234;
            //assign the data to the property
            aSupplier.SupplierID = TestData;
            //test to see that it exists
            Assert.AreEqual(aSupplier.SupplierID, TestData);
        }


        [TestMethod]
        public void NamePropertyOK()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //Create some test data to assign to the property
            string TestData = "John";
            //assign the data to the property
            aSupplier.Name = TestData;
            //test to see that it exists
            Assert.AreEqual(aSupplier.Name, TestData);
        }


        [TestMethod]
        public void EmailPropertyOK()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //Create some test data to assign to the property
            string TestData = "y@yahoo.com";
            //assign the data to the property
            aSupplier.EmailAddress = TestData;
            //test to see that it exists
            Assert.AreEqual(aSupplier.EmailAddress, TestData);
        }

        [TestMethod]
        
        public void MobilePropertyOK()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //Create some test data to assign to the property
            string TestData = "7777777";
            //assign the data to the property
            aSupplier.MobileNo = TestData;
            //test to see that it exists
            Assert.AreEqual(aSupplier.MobileNo, TestData);
        }

        [TestMethod]
        public void DOBOK()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "01/01/2001";
            //assign the data to the property
            aSupplier.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aSupplier.DOB, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //Create some test data to use
            int SupplierID = 111;
            //invoker the method
            Found = aSupplier.Find(SupplierID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            int SupplierID =111;
            //invoker the method
            Found = aSupplier.Find(SupplierID);
            //check the address no
            if (aSupplier.Address != "Le4")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestSupplierIDFound()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            int SupplierID = 111;
            //invoker the method
            Found = aSupplier.Find(SupplierID);
            //check the address no
            if (aSupplier.SupplierID != 111)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

       

        [TestMethod]
        public void TestNameFound()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            Int32 SupplierID = 111;
            //invoker the method
            Found = aSupplier.Find(SupplierID);
            //check the address no
            if (aSupplier.Name != "John")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

       

        [TestMethod]
        public void TestEmailFound()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            int SupplierID = 222;
            //invoker the method
            Found = aSupplier.Find(SupplierID);
            //check the address no
            if (aSupplier.Email != "y@yahoo.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestMobileNo()
        {
            //Create an instance of class
            clsSupplier aSupplier = new clsSupplier();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            int SupplierID = 222;
            //invoker the method
            Found = aSupplier.Find(SupplierID);
            //check the address no
            if (aSupplier.MobileNo != "8888888")
            {
                OK = false;
            }
            //test to see that the result is correct
              Assert.IsTrue(OK);
            
        }
    }
}