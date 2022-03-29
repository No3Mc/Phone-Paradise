using PSSClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
//Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
//Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store

namespace PhoneSystemTesting
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass to the method
        string StockName = "aa";
        string WarehouseNo = "aa";
        string Location= "aa";
        string Quantity= "aa";
        string Barcode= "aa";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }
        //ValidMethodOK
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String Error = "";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");

        }
        //findok
        [TestMethod]
        public void FindOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            Boolean Found = false;
            int TestData = 68;
            Found = AStock.Find(TestData);
            Assert.IsTrue(Found);
        }

        //ActivePropertyOK
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AStock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Active, TestData);
            
        }



        //Property Tests
        //StockIDPropertyOK
        [TestMethod]
        public void StockIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockID, TestData);
        }
        //StockNamePropertyOK
        [TestMethod]
        public void StockNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "aassa";
            //assign the data to the property
            AStock.StockName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockName, TestData);
        }
        //WarehouseNoPropertyOK
        [TestMethod]
        public void WarehouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "ab";
            //assign the data to the property
            AStock.WarehouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.WarehouseNo, TestData);
        }

        //LocationPropertyOK
        [TestMethod]
        public void LocationPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "ab";
            //assign the data to the property
            AStock.Location = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Location, TestData);
        }

        //QuantityPropertyOK
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "ab";
            //assign the data to the property
            AStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Quantity, TestData);
        }

        //BarcodePropertyOK
        [TestMethod]
        public void BarcodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "ab";
            //assign the data to the property
            AStock.Barcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Barcode, TestData);
        }

        //Found Tests
        //FindMethodOK

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockID = 68;
            //invoke the method
            Found = AStock.Find(StockID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        //TestStockIDFound
        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 68;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.StockID != 68)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        //TestStockNameFound
        [TestMethod]
        public void TestStockNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 68;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.StockName != "Apple")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //TestWarehouseNoFound
        [TestMethod]
        public void TestWarehouseNoFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 68;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.WarehouseNo != "Mul-725")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        //TestQuantityFound
        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 68;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Quantity != "89.94 metric tonnes")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        //TestBarcodeFound
        [TestMethod]
        public void TestBarcodeFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 68;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Barcode != "FE570FB3A3E81FF3EC45AF7FE429020C")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        //TestLocationFound
        [TestMethod]
        public void TestLocationFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 68;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Location != "Multan")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //TDD Tests of StockName, WarehouseNo, Location, Quantity, Barcode


        //Barcode Tests

        //BarcodeMinLessOne
        [TestMethod]
        public void BarcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Barcode = "";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //BarcodeMin
        [TestMethod]
        public void BarcodeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Barcode = "a";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //BarcodeMinPlusOne
        [TestMethod]
        public void BarcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Barcode = "aa";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //BarcodeMaxLessOne
        [TestMethod]
        public void BarcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Barcode = "";
            Barcode = Barcode.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //BarcodeMax
        [TestMethod]
        public void BarcodeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Barcode = "";
            Barcode = Barcode.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //BarcodeMaxPlusOne
        [TestMethod]
        public void BarcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Barcode = "";
            Barcode = Barcode.PadRight(51, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //BarcodeMid
        [TestMethod]
        public void BarcodeMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Barcode = "";
            Barcode = Barcode.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //BarcodeExtremeMax
        [TestMethod]
        public void BarcodeExtremeMax()
        {
            //instance of the class
            clsStock AStock = new clsStock();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Barcode = "";
            Barcode = Barcode.PadRight(200, 'a'); //this should fail
                                                  //assign test data to property
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        //Quantity
        //QuantityMinLessOne


        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //QuantityMin
        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "a";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //QuantityMinPlusOne
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "aa";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //QuantityMaxLessOne
        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "";
            Quantity = Quantity.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //QuantityMax
        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "";
            Quantity = Quantity.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //QuantityMaxPlusOne
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Quantity = "";
            Quantity = Quantity.PadRight(51, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //QuantityMid
        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "";
            Quantity = Quantity.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //QuantityExtremeMax
        [TestMethod]
        public void QuantityExtremeMax()
        {
            //instance of the class
            clsStock AStock = new clsStock();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Quantity = "";
            Quantity = Quantity.PadRight(200, 'a'); //this should fail
                                                  //assign test data to property
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        //Location
        //LocationMinLessOne

        [TestMethod]
        public void LocationMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Location = "";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //LocationMin
        [TestMethod]
        public void LocationMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Location = "a";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //LocationMinPlusOne
        [TestMethod]
        public void LocationMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Location = "aa";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //LocationMaxLessOne
        [TestMethod]
        public void LocationMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Location = "";
            Location = Location.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //LocationMax
        [TestMethod]
        public void LocationMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Location = "";
            Location = Location.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //LocationMaxPlusOne
        [TestMethod]
        public void LocationMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Location = "";
            Location = Location.PadRight(51, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //LocationMid
        [TestMethod]
        public void LocationMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Location = "";
            Location = Location.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //LocationExtremeMax
        [TestMethod]
        public void LocationExtremeMax()
        {
            //instance of the class
            clsStock AStock = new clsStock();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Location = "";
            Location = Location.PadRight(200, 'a'); //this should fail
                                                  //assign test data to property
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }


        //WarehouseNo
        //WarehouseNoMinLessOne
        [TestMethod]
        public void WarehouseNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string WarehouseNo = "";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //WarehouseNoMin
        [TestMethod]
        public void WarehouseNoMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string WarehouseNo = "a";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //WarehouseNoMinPlusOne
        [TestMethod]
        public void WarehouseNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string WarehouseNo = "aa";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //WarehouseNoMaxLessOne
        [TestMethod]
        public void WarehouseNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string WarehouseNo = "";
            WarehouseNo = WarehouseNo.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //WarehouseNoMax
        [TestMethod]
        public void WarehouseNoMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string WarehouseNo = "";
            WarehouseNo = WarehouseNo.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //WarehouseNoMaxPlusOne
        [TestMethod]
        public void WarehouseNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string WarehouseNo = "";
            WarehouseNo = WarehouseNo.PadRight(51, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //WarehouseNoMid
        [TestMethod]
        public void WarehouseNoMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string WarehouseNo = "";
            WarehouseNo = WarehouseNo.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //WarehouseNoExtremeMax
        [TestMethod]
        public void WarehouseNoExtremeMax()
        {
            //instance of the class
            clsStock AStock = new clsStock();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string WarehouseNo = "";
            WarehouseNo = WarehouseNo.PadRight(200, 'a'); //this should fail
                                                  //assign test data to property
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        //StockName
        //StockNameMinLessOne



        [TestMethod]
        public void StockNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StockName = "";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //StockNameMin
        [TestMethod]
        public void StockNameMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockName = "a";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //StockNameMinPlusOne
        [TestMethod]
        public void StockNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockName = "aa";
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //StockNameMaxLessOne
        [TestMethod]
        public void StockNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockName = "";
            StockName = StockName.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, StockName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //StockNameMax
        [TestMethod]
        public void StockNameMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockName = "";
            StockName = StockName.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, StockName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //StockNameMaxPlusOne
        [TestMethod]
        public void StockNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string StockName = "";
            StockName = StockName.PadRight(51, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, StockName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //StockNameMid
        [TestMethod]
        public void StockNameMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockName = "";
            StockName = StockName.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, StockName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //StockNameExtremeMax
        [TestMethod]
        public void StockNameExtremeMax()
        {
            //instance of the class
            clsStock AStock = new clsStock();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string StockName = "";
            StockName = StockName.PadRight(200, 'a'); //this should fail
                                                  //assign test data to property
            Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }


    }


}

