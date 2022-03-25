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
    public class SupplierCollection
    {
       
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection aSuppliers = new clsSupplierCollection();
            //test to see that it exist;
            Assert.IsNotNull(aSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection aSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.SupplierID = 111;
            TestItem.Name = "John";
            TestItem.Address = "Le4";
            TestItem.MobileNo = "7777777";
            TestItem.Email = "g@gmail.com";
            TestItem.DOB = "01/01/2001";
            //add the item to the test list
            TestList.Add(TestItem);
            aSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(aSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection aSuppliers = new clsSupplierCollection();

            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplierID = 111;
            TestItem.Name = "John";
            TestItem.Address = "Le4";
            TestItem.MobileNo = "7777777";
            TestItem.Email = "g@gmail.com";
            TestItem.DOB = "01/01/2001";
            //set ThisStock to the test data
            aSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = aSuppliers.Add();
            //set the primary key of the test data
            TestItem.SupplierID = PrimaryKey;
            //find the record
            aSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see the two values are the same
            Assert.AreEqual(aSuppliers.ThisSupplier, TestItem);

        }



        [TestMethod]
        public void DelMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection aSuppliers = new clsSupplierCollection();

            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplierID = 111;
            TestItem.Name = "John";
            TestItem.Address = "Le4";
            TestItem.MobileNo = "7777777";
            TestItem.Email = "g@gmail.com";
            TestItem.DOB = "01/01/2001";
            //set ThisStock to the test data
            aSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = aSuppliers.Add();
            //set the primary key of the test data
            TestItem.SupplierID = PrimaryKey;
            //find the record
            aSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see the two values are the same
            aSuppliers.Delete();
            Assert.AreEqual(aSuppliers.ThisSupplier, TestItem);

        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection aSuppliers = new clsSupplierCollection();

            //create some test data to assign for the property
            //in this case the data need to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.SupplierID = 111;
            TestItem.Name = "John";
            TestItem.Address = "Le4";
            TestItem.MobileNo = "7777777";
            TestItem.Email = "g@gmail.com";
            TestItem.DOB = "01/01/2001";

            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            aSuppliers.SupplierList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(aSuppliers.Count, TestList.Count);
        }



        [TestMethod]
        public void UpdateMethodOK()
        {
            //create ab instance of teh class we want to create
            clsSupplierCollection aSuppliers = new clsSupplierCollection();

            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplierID = 111;
            TestItem.Name = "John";
            TestItem.Address = "Le4";
            TestItem.MobileNo = "7777777";
            TestItem.Email = "g@gmail.com";
            TestItem.DOB = "01/01/2001";
            //set thisstock to the test data
            aSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = aSuppliers.Add();
            //set the primary key of the test data
            TestItem.SupplierID = PrimaryKey;
            //modify the test data
            TestItem.SupplierID = 111;
            TestItem.Name = "John";
            TestItem.Address = "Le4";
            TestItem.MobileNo = "7777777";
            TestItem.Email = "g@gmail.com";
            TestItem.DOB = "01/01/2001";
            //set the record based on the new test data
            Assert.AreEqual(aSuppliers.ThisSupplier, TestItem);
        }


    }
}
