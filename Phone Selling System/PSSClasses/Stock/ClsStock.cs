using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace PSSClasses
{
    public class clsStock
    {
        public bool Active;
        private int NStockID;
        private string NStockName;
        private string NWarehouseNo;
        private string NLocation;
        private string NQuantity;
        private string NBarcode;


        public int StockID
        {
            get
            {
                //this line of code send data out of the property
                return NStockID;
            }
            set
            {
                //this line of code allows data into the property
                NStockID = value;
            }

        }

        public bool Find(int StockID)
        {
            //create an instance of the data connectin
            clsDataConnection DB = new clsDataConnection();
            //add the parametrs for the book to search for it
            DB.AddParameter("@StockID", StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockID");


            //if one record if found (there should either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                NStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                NStockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                NWarehouseNo = Convert.ToString(DB.DataTable.Rows[0]["WarehouseNo"]);
                NLocation = Convert.ToString(DB.DataTable.Rows[0]["Location"]);
                NQuantity = Convert.ToString(DB.DataTable.Rows[0]["Quantity"]);
                NBarcode = Convert.ToString(DB.DataTable.Rows[0]["Barcode"]);

                //return everyting worked OK
                return true;
            }

            //if no records was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid(string StockName, string WarehouseNo, string Location, string Quantity, string Barcode)
        {


            //if (string.IsNullOrEmpty(StockName))
            //{
            //    throw new ArgumentException($"'{nameof(StockName)}' cannot be null or empty.", nameof(StockName));
            //}

            //if (string.IsNullOrEmpty(WarehouseNo))
            //{
            //    throw new ArgumentException($"'{nameof(WarehouseNo)}' cannot be null or empty.", nameof(WarehouseNo));
            //}

            //if (string.IsNullOrEmpty(Location))
            //{
            //    throw new ArgumentException($"'{nameof(Location)}' cannot be null or empty.", nameof(Location));
            //}

            //if (string.IsNullOrEmpty(Quantity))
            //{
            //    throw new ArgumentException($"'{nameof(Quantity)}' cannot be null or empty.", nameof(Quantity));
            //}

            //if (string.IsNullOrEmpty(Barcode))
            //{
            //    throw new ArgumentException($"'{nameof(Barcode)}' cannot be null or empty.", nameof(Barcode));
            //}



            //create a string variable to store the error
            string Error = "";
            if (WarehouseNo.Length == 0)
            {
                //record the error
                Error = Error + "The warehouse no may not be black";
            }
            //return error messages
            return Error;
        }





        public string StockName
        {
            get
            {
                //this line of code send data out of the property
                return NStockName;
            }
            set
            {
                //this line of code allows data into the property
                NStockName = value;
            }

        }


        public string WarehouseNo
        {
            get
            {
                //this line of code send data out of the property
                return NWarehouseNo;
            }
            set
            {
                //this line of code allows data into the property
                NWarehouseNo = value;
            }

        }


        public string Location
        {
            get
            {
                //this line of code send data out of the property
                return NLocation;
            }
            set
            {
                //this line of code allows data into the property
                NLocation = value;
            }

        }


        public string Quantity
        {
            get
            {
                //this line of code send data out of the property
                return NQuantity;
            }
            set
            {
                //this line of code allows data into the property
                NQuantity = value;
            }

        }


        public string Barcode
        {
            get
            {
                //this line of code send data out of the property
                return NBarcode;
            }
            set
            {
                //this line of code allows data into the property
                NBarcode = value;
            }

        }



        public bool List()
        {
            //always return true
            return true;
        }
















    }


}
