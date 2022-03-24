using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSSClasses;
using PSSClasses.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSystemTesting.Phone
{
    [TestClass]
    public class tstPhoneCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //test to see that it exist;
            Assert.IsNotNull(AllPhones);
        }

        [TestMethod]
        public void PhoneListOK()
        {
            //create an instance of the class we want to create
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsPhone> TestList = new List<clsPhone>();
            //add an item to the list
            //create the item of test data
            clsPhone TestItem = new clsPhone();
            //set its properties
            TestItem.PhoneID = 1;
            TestItem.PhoneName = "a";
            TestItem.PhoneManufacturer = "a";
            TestItem.BatteryCapacity = "a";
            TestItem.CameraQuality = "a";
            TestItem.StorageCapacity = "a";
            TestItem.DisplaySize = "a";
            //add the item to the test list
            TestList.Add(TestItem);
            AllPhones.PhoneList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPhones.PhoneList, TestList);
        }


        [TestMethod]
        public void ThisPhoneOK()
        {
            //create an instance of the class we want to create
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create some test data to assign to the property
            clsPhone TestPhone = new clsPhone();
            //set the properties of the test object
            TestPhone.PhoneID = 1;
            TestPhone.PhoneName = "a";
            TestPhone.PhoneManufacturer = "a";
            TestPhone.BatteryCapacity = "a";
            TestPhone.CameraQuality = "a";
            TestPhone.StorageCapacity = "a";
            TestPhone.DisplaySize = "a";
            //assign the data to the property
            AllPhones.ThisPhone = TestPhone;
            Assert.AreEqual(AllPhones.ThisPhone, TestPhone);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create the item of test data
            clsPhone TestItem = new clsPhone();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PhoneID = 1;
            TestItem.PhoneName = "a";
            TestItem.PhoneManufacturer = "a";
            TestItem.BatteryCapacity = "a";
            TestItem.CameraQuality = "a";
            TestItem.StorageCapacity = "a";
            TestItem.DisplaySize = "a";
            //set ThisStock to the test data
            AllPhones.ThisPhone = TestItem;
            //add the record
            PrimaryKey = AllPhones.Add();
            //set the primary key of the test data
            TestItem.PhoneID = PrimaryKey;
            //find the record
            AllPhones.ThisPhone.Find(PrimaryKey);
            //test to see the two values are the same
            Assert.AreEqual(AllPhones.ThisPhone, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create the item of test data
            clsPhone TestItem = new clsPhone();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PhoneID = 1;
            TestItem.PhoneName = "a";
            TestItem.PhoneManufacturer = "a";
            TestItem.BatteryCapacity = "a";
            TestItem.CameraQuality = "a";
            TestItem.StorageCapacity = "a";
            TestItem.DisplaySize = "a";
            //set ThisStock to the test data
            AllPhones.ThisPhone = TestItem;
            //add the record
            PrimaryKey = AllPhones.Add();
            //set the primary key of the test data
            TestItem.PhoneID = PrimaryKey;
            //find the record
            AllPhones.ThisPhone.Find(PrimaryKey);
            //test to see the two values are the same
            AllPhones.Delete();
            Assert.AreEqual(AllPhones.ThisPhone, TestItem);

        }

        [TestMethod]
        public void ListOK()
        {
            //create an instance of the class we want to create
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create some test data to assign for the property
            //in this case the data need to be a list of objects
            List<clsPhone> TestList = new List<clsPhone>();
            //add an item to the list
            //create the item of test data
            clsPhone TestItem = new clsPhone();
            //set its properties
            TestItem.PhoneID = 1;
            TestItem.PhoneName = "a";
            TestItem.PhoneManufacturer = "a";
            TestItem.BatteryCapacity = "a";
            TestItem.CameraQuality = "a";
            TestItem.StorageCapacity = "a";
            TestItem.DisplaySize = "a";

            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllPhones.PhoneList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllPhones.Count, TestList.Count);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create ab instance of teh class we want to create
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create the item of test data
            clsPhone TestItem = new clsPhone();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PhoneID = 1;
            TestItem.PhoneName = "a";
            TestItem.PhoneManufacturer = "a";
            TestItem.BatteryCapacity = "a";
            TestItem.CameraQuality = "a";
            TestItem.StorageCapacity = "a";
            TestItem.DisplaySize = "a";
            //set thisstock to the test data
            AllPhones.ThisPhone = TestItem;
            //add the record
            PrimaryKey = AllPhones.Add();
            //set the primary key of the test data
            TestItem.PhoneID = PrimaryKey;
            //modify the test data
            TestItem.PhoneName = "aaaa";
            TestItem.PhoneManufacturer = "aaaa";
            TestItem.BatteryCapacity = "aaaa";
            TestItem.CameraQuality = "aaaa";
            TestItem.StorageCapacity = "aaaa";
            TestItem.DisplaySize = "aaaa";
            //set the record based on the new test data
            Assert.AreEqual(AllPhones.ThisPhone, TestItem);
        }

        [TestMethod]
        public void FilterByNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create an instance of the filtered data
            clsPhoneCollection FilteredPhones = new clsPhoneCollection();
            //apply a blank string (should return all records)
            FilteredPhones.FilterByName("Apple");
            //test to see ThisBook mathces the test data
            Assert.AreEqual(AllPhones.Count, FilteredPhones.Count);
        }
    }
}
