using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSSClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSystemTesting.Phone
{
    [TestClass]
    public class tstPhone
    {
        string PhoneName = "aaa";
        string PhoneManufacturer = "aaa";
        string BatteryCapacity = "aaa";
        string CameraQuality = "aaa";
        string StorageCapacity = "aaa";
        string DisplaySize = "aaa";
        string DateReleased = "23/03/2020";

        [TestMethod]

        public void InstanceOK()
        {
            clsPhone APhone = new clsPhone();

            Assert.IsNotNull(APhone);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            clsPhone APhone = new clsPhone();
            String Error = "";
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, DisplaySize, DateReleased, StorageCapacity);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FindOK()
        {
            clsPhone APhone = new clsPhone();
            Boolean Found = false;
            int TestData = 1;
            Found = APhone.Find(TestData);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void PhoneIDOK()
        {
            clsPhone APhone = new clsPhone();

            Int32 TestData = 1;

            APhone.PhoneID = TestData;

            Assert.AreEqual(APhone.PhoneID, TestData);
        }

        [TestMethod]
        public void PhoneNameOK()
        {
            clsPhone APhone = new clsPhone();

            string TestData = "iPhone 6";

            APhone.PhoneName = TestData;

            Assert.AreEqual(APhone.PhoneName, TestData);
        }

        [TestMethod]
        public void PhoneManufacturerOK()
        {
            clsPhone APhone = new clsPhone();

            string TestData = "Apple";

            APhone.PhoneManufacturer = TestData;

            Assert.AreEqual(APhone.PhoneManufacturer, TestData);
        }

        [TestMethod]
        public void BatteryCapacityOK()
        {
            clsPhone APhone = new clsPhone();

            string TestData = "3000mah";

            APhone.BatteryCapacity = TestData;

            Assert.AreEqual(APhone.BatteryCapacity, TestData);
        }

        [TestMethod]
        public void CameraQualityOK()
        {
            clsPhone APhone = new clsPhone();

            string TestData = "24mp";

            APhone.CameraQuality = TestData;

            Assert.AreEqual(APhone.CameraQuality, TestData);
        }

        [TestMethod]
        public void StorageCapacityOK()
        {
            clsPhone APhone = new clsPhone();

            string TestData = "64gb";

            APhone.StorageCapacity = TestData;

            Assert.AreEqual(APhone.StorageCapacity, TestData);
        }

        [TestMethod]
        public void DisplaySizeOK()
        {
            clsPhone APhone = new clsPhone();

            string TestData = "6.8";

            APhone.DisplaySize = TestData;

            Assert.AreEqual(APhone.DisplaySize, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsPhone APhone = new clsPhone();

            Boolean Found = false;

            Int32 PhoneID = 1;

            Found = APhone.Find(PhoneID);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPhoneIDFound()
        {
            
            clsPhone APhone = new clsPhone();
            
            Boolean Found = false;
            
            Boolean OK = true;
            
            Int32 PhoneID = 1;
            
            Found = APhone.Find(PhoneID);
           
            if (APhone.PhoneID != 1)
            {
                OK = false;
            }
            
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNameFound()
        {

            clsPhone APhone = new clsPhone();

            Boolean Found = false;

            Boolean OK = true;

            Int32 PhoneID = 1;

            Found = APhone.Find(PhoneID);

            if (APhone.PhoneName != "1")
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

            Int32 PhoneID = 1;

            Found = APhone.Find(PhoneID);

            if (APhone.PhoneManufacturer != "1")
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

            if (APhone.BatteryCapacity != "1")
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

            if (APhone.CameraQuality != "1")
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

            if (APhone.StorageCapacity != "1")
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

            if (APhone.DisplaySize != "1")
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
            //this should fail
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
            //this should fail
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
            //this should fail
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
            //this should pass
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
            //this should pass
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
            //this should fail
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
            //this should pass
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
            //this should pass
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
            //this should fail
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
            //this should pass
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
            //this should pass
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
            //this should fail
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
            //this should pass
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
            //this should pass
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
            //this should fail
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
            //this should pass
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
            //this should pass
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
            //this should fail
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
            //this should pass
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
            //this should pass
            string DisplaySize = "";
            DisplaySize = DisplaySize.PadRight(200, 'a');
            //invoke the method
            Error = APhone.Valid(PhoneName, PhoneManufacturer, BatteryCapacity, CameraQuality, StorageCapacity, DisplaySize, DateReleased);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
