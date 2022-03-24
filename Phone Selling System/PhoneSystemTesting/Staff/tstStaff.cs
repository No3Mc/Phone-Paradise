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
            //create an instance od the class
            clsStaff AStaff = new clsStaff();
            //test to see if it exsists
            Assert.IsNotNull(AStaff);
        }
    }
}
