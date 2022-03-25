using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSSClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Written by Ethan Frizzell P2596393

namespace PhoneSystemTesting.Phone
{
    [TestClass]
    public class tstPhone
    {
        //test data
        string PhoneName = "aaa";
        string PhoneManufacturer = "aaa";
        string BatteryCapacity = "aaa";
        string CameraQuality = "aaa";
        string StorageCapacity = "aaa";
        string DisplaySize = "aaa";

        DateTime DateReleased = Convert.ToDateTime("2022, 02, 1");
        [TestMethod]

        public void InstanceOK()
        {
            //create an instance of the phone class
            clsPhone APhone = new clsPhone();
            //test to see that it exists
            Assert.IsNotNull(APhone);
        }

        [TestMethod]

        public void ValidMethodOK() //testing valid method
        {
            //create an instance of the phone class
            clsPhone APhone = new clsPhone();
            //create test data
            String Error = "";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the two values are equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FindOK()
        {
            //create an instance of the phone class
            clsPhone APhone = new clsPhone();
            //create a boolean variable
            Boolean Found = false;
            int TestData = 1;
            Found = APhone.Find(TestData);
            //test that a record is found
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void PhoneIDOK()
        {
            //create a new instance of the phone class
            clsPhone APhone = new clsPhone();
            //create some test data
            Int32 TestData = 1;
            //invoke the method
            APhone.PhoneID = TestData;
            //test to see that the values are equal
            Assert.AreEqual(APhone.PhoneID, TestData);
        }

        [TestMethod]
        public void PhoneNameOK()
        {
            //create a new instance of the phone class
            clsPhone APhone = new clsPhone();
            //create some test data

            string TestData = "iPhone 6";
            //invoke the method

            APhone.PhoneName = TestData;
            //test to see that the values are equal

            Assert.AreEqual(APhone.PhoneName, TestData);
        }

        [TestMethod]
        public void PhoneManufacturerOK()
        {
            //create a new instance of the phone class

            clsPhone APhone = new clsPhone();
            //create some test data

            string TestData = "Apple";
            //invoke the method

            APhone.PhoneManufacturer = TestData;
            //test to see that the values are equal

            Assert.AreEqual(APhone.PhoneManufacturer, TestData);
        }

        [TestMethod]
        public void BatteryCapacityOK()
        {
            //create a new instance of the phone class

            clsPhone APhone = new clsPhone();
            //create some test data

            string TestData = "3000mah";
            //invoke the method

            APhone.BatteryCapacity = TestData;
            //test to see that the values are equal

            Assert.AreEqual(APhone.BatteryCapacity, TestData);
        }

        [TestMethod]
        public void CameraQualityOK()
        {
            //create a new instance of the phone class

            clsPhone APhone = new clsPhone();
            //create some test data

            string TestData = "24mp";
            //invoke the method

            APhone.CameraQuality = TestData;
            //test to see that the values are equal

            Assert.AreEqual(APhone.CameraQuality, TestData);
        }

        [TestMethod]
        public void StorageCapacityOK()
        {
            //create a new instance of the phone class

            clsPhone APhone = new clsPhone();
            //create some test data

            string TestData = "64gb";
            //invoke the method

            APhone.StorageCapacity = TestData;
            //test to see that the values are equal


            Assert.AreEqual(APhone.StorageCapacity, TestData);
        }

        [TestMethod]
        public void DisplaySizeOK()
        {
            //create a new instance of the phone class

            clsPhone APhone = new clsPhone();
            //create some test data

            string TestData = "aaa";

            APhone.DisplaySize = TestData;
            //test to see that the values are equal

            Assert.AreEqual(APhone.DisplaySize, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create a new instance of the phone class

            clsPhone APhone = new clsPhone();

            Boolean Found = false;
            //create some test data
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //test to see if record is found
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPhoneIDFound()
        {
            //create a new instance of the phone class

            clsPhone APhone = new clsPhone();
            //create boolean variable to store result
            Boolean Found = false;
            //test that data is OK
            Boolean OK = true;
            //create test data
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
           //check the result
            if (APhone.PhoneID != 1)
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNameFound()
        {

            clsPhone APhone = new clsPhone();

            Boolean Found = false;

            Boolean OK = true;

            Int32 PhoneID = 2;

            Found = APhone.Find(PhoneID);

            if (APhone.PhoneName != "iPhone 6")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneManufacturerFound()
        {

            clsPhone APhone = new clsPhone();

            Boolean Found = false;

            Boolean OK = true;

            Int32 PhoneID = 2;

            Found = APhone.Find(PhoneID);

            if (APhone.PhoneManufacturer != "Apple")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBatteryCapacityFound()
        {

            clsPhone APhone = new clsPhone();

            Boolean Found = false;

            Boolean OK = true;

            Int32 PhoneID = 1;

            Found = APhone.Find(PhoneID);

            if (APhone.BatteryCapacity != "TestData")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCameraQualityFound()
        {

            clsPhone APhone = new clsPhone();

            Boolean Found = false;

            Boolean OK = true;

            Int32 PhoneID = 1;

            Found = APhone.Find(PhoneID);

            if (APhone.CameraQuality != "Test")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStorageCapacityFound()
        {

            clsPhone APhone = new clsPhone();

            Boolean Found = false;

            Boolean OK = true;

            Int32 PhoneID = 1;

            Found = APhone.Find(PhoneID);

            if (APhone.StorageCapacity != "Test")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDisplaySizeFound()
        {

            clsPhone APhone = new clsPhone();

            Boolean Found = false;

            Boolean OK = true;

            Int32 PhoneID = 1;

            Found = APhone.Find(PhoneID);

            if (APhone.DisplaySize != "Test")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        //PhoneName Valid Tests

        [TestMethod]
        public void PhoneNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail as it is blank
            string PhoneName = "";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMin()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneName = "a";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneName = "aa";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone= new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneName = "";
            PhoneName = PhoneName.PadRight(39, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneName = "";
            PhoneName = PhoneName.PadRight(40, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneName = "";
            PhoneName = PhoneName.PadRight(41, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMid()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneName = "";
            PhoneName = PhoneName.PadRight(20, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneName = "";
            PhoneName = PhoneName.PadRight(200, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        //PhoneManufacturer Valid Tests

        [TestMethod]
        public void PhoneManufacturerMinLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneManufacturer = "";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneManufacturerMin()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneManufacturer = "a";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneManufacturerMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneManufacturer = "aa";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneManufacturerMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneManufacturer = "";
            PhoneManufacturer = PhoneManufacturer.PadRight(39, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonemanufacturerMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneManufacturer = "";
            PhoneManufacturer = PhoneManufacturer.PadRight(40, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneManufacturerMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneManufacturer = "";
            PhoneManufacturer = PhoneManufacturer.PadRight(41, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneManufacturerMid()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneManufacturer = "";
            PhoneManufacturer = PhoneManufacturer.PadRight(20, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneManufacturerExtremeMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneManufacturer = "";
            PhoneManufacturer = PhoneManufacturer.PadRight(200, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        //BatteryCapacity Valid Tests

        [TestMethod]
        public void BatteryCapacityMinLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string BatteryCapacity = "";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BatteryCapacityMin()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BatteryCapacity = "a";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BatteryCapacityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BatteryCapacity = "aa";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BatteryCapacityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BatteryCapacity = "";
            BatteryCapacity = BatteryCapacity.PadRight(6, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BatteryCapacityMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BatteryCapacity = "";
            BatteryCapacity = BatteryCapacity.PadRight(7, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BatteryCapacityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string BatteryCapacity = "";
            BatteryCapacity = BatteryCapacity.PadRight(8, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BatteryCapacityMid()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneManufacturer = "";
            PhoneManufacturer = PhoneManufacturer.PadRight(3, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BatteryCapacityExtremeMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string BatteryCapacity = "";
            BatteryCapacity = BatteryCapacity.PadRight(200, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        //CameraQuality Valid Tests

        [TestMethod]
        public void CameraQualityMinLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CameraQuality = "";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMin()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CameraQuality = "a";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CameraQuality = "aa";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CameraQuality = "aaa";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BatteryCapacity = "aaaaa";
            
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CameraQuality = "aaaaaa";
            
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityMid()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CameraQuality = "aa";
            
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CameraQualityExtremeMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CameraQuality = "";
            CameraQuality = CameraQuality.PadRight(200, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





        //StorageCapacity Valid Tests

        [TestMethod]
        public void StorageCapacityMinLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StorageCapacity = "";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StorageCapacityMin()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StorageCapacity = "a";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StorageCapacityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StorageCapacity = "aa";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StorageCapacityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StorageCapacity = "aaaa";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StorageCapacityMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StorageCapacity = "aaaaa";

            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StorageCapacityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StorageCapacity = "aaaaaa";

            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StorageCapacityMid()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StorageCapacity = "aa";

            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StorageCapacityExtremeMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StorageCapacity = "";
            StorageCapacity = StorageCapacity.PadRight(200, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }






        //DisplaySize Valid Tests

        [TestMethod]
        public void DisplaySizeMinLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string DisplaySize = "";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DisplaySizeMin()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string DisplaySize = "a";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DisplaySizeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string DisplaySize = "aa";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DisplaySizeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string DisplaySize = "aaaa";
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DisplaySizeMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string DisplaySize = "aaaaa";

            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DisplaySizeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string DisplaySize = "aaaaaa";

            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DisplaySizeMid()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string DisplaySize = "aa";

            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DisplaySizeExtremeMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string DisplaySize = "";
            DisplaySize = DisplaySize.PadRight(200, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
