using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSSClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSystemTesting.Staff
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exist;
            Assert.IsNotNull(AllStaff);
        }


    }
}
