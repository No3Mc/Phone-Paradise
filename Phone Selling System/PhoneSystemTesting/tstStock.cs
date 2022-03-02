//using PSSClasses;
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
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Active, TestData);
            
        }



    }

    class clsStock
    {
        public bool Active { get; internal set; }
    }
}

