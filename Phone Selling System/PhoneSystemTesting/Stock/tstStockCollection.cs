using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSSClasses;



namespace PhoneSystemTesting
{

    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exist;
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.StockID = 1;
            TestItem.StockName = "a";
            TestItem.WarehouseNo = "a";
            TestItem.Location = "a";
            TestItem.Quantity = "a";
            TestItem.Barcode = "a";
            //add the item to the test list
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the proeprty
            Int32 SomeCount = 0;
            //assign the data to the property
            AllStocks.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.StockID = 1;
            TestStock.StockName = "1";
            TestStock.Location = "1";
            TestStock.Quantity = "1";
            TestStock.WarehouseNo = "1";
            TestStock.Barcode = "1";
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            Assert.AreEqual(AllStocks.ThisStock, TestStock);

        }



        //got rid of these two tests according to the lab 23

        //[TestMethod]
        //public void ListAndCountOK()
        //{
        //    //create an instance of the class we want to create
        //    clsStockCollection AllStocks = new clsStockCollection();
        //    //create some test data to assign to the property
        //    //in this case the data needs to be a list of objects
        //    List<clsStock> TestList = new List<clsStock>();
        //    //add an item to the list
        //    //create the item of test data
        //    clsStock TestItem = new clsStock();
        //    //set its properties
        //    TestItem.StockID = 1;
        //    TestItem.StockName = "1";
        //    TestItem.Location = "1";
        //    TestItem.Quantity = "1";
        //    TestItem.WarehouseNo = "1";
        //    TestItem.Barcode = "1";
        //    //add the item to the test list
        //    TestList.Add(TestItem);
        //    //assign the data of the property
        //    AllStocks.StockList = TestList;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllStocks.Count, TestList.Count);

        //}


        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsStockCollection AllStocks = new clsStockCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllStocks.Count, 2);
        //}












        }


}
