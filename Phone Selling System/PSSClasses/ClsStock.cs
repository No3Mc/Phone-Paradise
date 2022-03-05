using System;



namespace PSSClasses
{
    public class clsStock
    {
        public bool Active;
        private Int32 NStockID;
        private string NStockName;
        private string NWarehouseNo;
        private string NLocation;
        private string NQuantity;
        private string NBarcode;


        public Int32 StockID
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

        public bool Find(Int32 stockID)
        {
            //create an instance of the data connectin
            clsDataConnection DB = new clsDataConnection();
            //add the parametrs for the book to search for it
            DB.AddParameter("@StockID", StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FillterByStockID");


            //if one record if found (there should either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                NStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                NStockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                NWarehouseNo = Convert.ToString(DB.DataTable.Rows[0]["StockWarehouseNo"]);
                NLocation = Convert.ToString(DB.DataTable.Rows[0]["StockLocation"]);
                NQuantity = Convert.ToString(DB.DataTable.Rows[0]["StockQuantity"]);
                NBarcode = Convert.ToString(DB.DataTable.Rows[0]["StockBarcode"]);

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

        public string Valid(string stockID, string stockName, string warehouseNo, string location, string quantity, string barcode)
        {
            return "";
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




















    }    
}
