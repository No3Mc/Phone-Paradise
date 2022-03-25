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
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.StaffEmail = "a";
            TestItem.StaffName = "a";
            TestItem.StaffPassword = "a";
            TestItem.StaffPosition = "a";
            TestItem.StaffTelephoneNo = "a";
            //add the item to the test list
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.StaffEmail = "1";
            TestItem.StaffName = "1";
            TestItem.StaffPassword = "1";
            TestItem.StaffPosition = "1";
            TestItem.StaffTelephoneNo = "1";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }



        [TestMethod]
        public void DelMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.StaffEmail = "1";
            TestItem.StaffName = "1";
            TestItem.StaffPassword = "1";
            TestItem.StaffPosition = "1";
            TestItem.StaffTelephoneNo = "1";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see the two values are the same
            AllStaff.Del();
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create ab instance of the class we wanted
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffEmail = "3";
            TestItem.StaffName = "3";
            TestItem.StaffPassword = "3";
            TestItem.StaffPosition = "3";   
            TestItem.StaffTelephoneNo = "3";
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //modify the test data
            TestItem.StaffEmail = "33";
            TestItem.StaffName = "33";
            TestItem.StaffPassword = "33";
            TestItem.StaffPosition = "33";
            TestItem.StaffTelephoneNo = "33";
            //set the record based on the new test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

    }
}
