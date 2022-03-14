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

        string Address = "aa";
        string DOB = "aa";
        string Name = "aa";
        string Email = "aa";
        string PhoneNo = "aa";

        


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustID);
            //check the property
            if (AnCustomer.CustID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestStockNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustID);
            //check the property
            if (AnCustomer.Address != "1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestWarehouseNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustID);
            //check the property
            if (AnCustomer.DOB != "1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustID);
            //check the property
            if (AnCustomer.Name != "1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestBarcodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustID);
            //check the property
            if (AnCustomer.Email != "1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestLocationFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustID);
            //check the property
            if (AnCustomer.PhoneNo != "1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }














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
            string TestData = "LE1 4AB";
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
            string TestData = "LE1 4AB";
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
            string TestData = "LE1 4AB";
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
            string TestData = "LE1 4AB";
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
            string TestData = "LE1 4AB";
            //assign the data to the property
            ACustomer.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }


















    }
}
