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
            clsStockCollection AllStock = new clsStockCollection();
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
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }
























    }


}
