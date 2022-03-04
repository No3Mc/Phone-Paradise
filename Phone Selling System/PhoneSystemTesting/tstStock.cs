using PSSClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhoneSystemTesting
{
    [TestClass]
    public class tstStock
    {


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            bool Found = false;
            //assign the data to the property
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //test to see that the two values are the same
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            bool Found = false;
            //bool variable to record if data is OK (assume it is)
            bool OK = true;
            //assign the data to the property
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //checks the stock's ID for validation
            if (AStock.StockID != 1)
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);

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



    }


}

