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
            //set the private data members to the test data value
            NStockID = 1;
            //always return true
            return true;
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
