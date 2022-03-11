using PSSClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PhoneSystemTesting
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass to the method
        string StockName = "aa";
        string WarehouseNo = "aa";
        string Location= "aa";
        string Quantity= "aa";
        string Barcode= "aa";








        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AStock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Active, TestData);
            
        }




        //Property Tests

        [TestMethod]
        public void StockIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockID, TestData);
        }

        [TestMethod]
        public void StockNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "aassa";
            //assign the data to the property
            AStock.StockName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockName, TestData);
        }

        [TestMethod]
        public void WarehouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "ab";
            //assign the data to the property
            AStock.WarehouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.WarehouseNo, TestData);
        }


        [TestMethod]
        public void LocationPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "ab";
            //assign the data to the property
            AStock.Location = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Location, TestData);
        }


        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "ab";
            //assign the data to the property
            AStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Quantity, TestData);
        }


        [TestMethod]
        public void BarcodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "ab";
            //assign the data to the property
            AStock.Barcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Barcode, TestData);
        }












        //Found Tests

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.StockID != 1)
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
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.StockName != "1")
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
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.WarehouseNo != "1")
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
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Quantity != "1")
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
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Barcode != "1")
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
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Location != "1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


























        //TDD Tests

        [TestMethod]
        public void WarehouseNoLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string WarehouseNo = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



    }


}

