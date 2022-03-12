using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
//Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store

namespace PSSClasses
{
    public class clsStockCollection
    {


        
        //private data member for the list
        List<clsStock> NStockList = new List<clsStock>();
        //public List<clsStock> StockList { get; set; }
        public int Counts { get; set; }
        clsStock NThisStock = new clsStock();


        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return NThisStock;
            }
            set
            {
                //set private data
                NThisStock = value;
            }
        }


        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return NStockList;
            }
            set
            {
                //set the private data
                NStockList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return NStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }


        public clsStockCollection()
        {

            //objcet for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);

        }
        //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode


        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            int Index = 0;
            //var to store the record count 
            int RecordsCount = 0;
            //get the count of records
            RecordsCount = DB.Count;
            //clear the private array list
            NStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordsCount)
            {
                //create a blank book
                clsStock AStock = new clsStock();
                //read in the fields from the current records
                AStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AStock.StockName = Convert.ToString(DB.DataTable.Rows[Index]["StockName"]);
                AStock.WarehouseNo = Convert.ToString(DB.DataTable.Rows[Index]["WarehouseNo"]);
                AStock.Location = Convert.ToString(DB.DataTable.Rows[Index]["Location"]);
                AStock.Quantity = Convert.ToString(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.Barcode = Convert.ToString(DB.DataTable.Rows[Index]["Barcode"]);






                //add the record to the private data member
                NStockList.Add(AStock);
                //point at the record
                Index++;
            }
        }


        public void Del()
        {
            //delete the record pointed by the thisStock
            //connects database
            clsDataConnection DB = new clsDataConnection();
            //parameters for the stored procedure
            DB.AddParameter("@StockID", NThisStock.StockID);
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_Del");
        }


        public int Add()
        {
            //adds a new record to the database based on the values
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockName", NThisStock.StockName);
            DB.AddParameter("@WarehouseNo", NThisStock.WarehouseNo);
            DB.AddParameter("@Location", NThisStock.Location);
            DB.AddParameter("@Quantity", NThisStock.Quantity);
            DB.AddParameter("@Barcode", NThisStock.Barcode);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
            //return the primary key of the new record
            //return NThisStock.StockID;
        }


        public void Update()
        {
            //adds a new record to the database based on the values
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockID", NThisStock.StockID);
            DB.AddParameter("@StockName", NThisStock.StockName);
            DB.AddParameter("@WarehouseNo", NThisStock.WarehouseNo);
            DB.AddParameter("@Location", NThisStock.Location);
            DB.AddParameter("@Quantity", NThisStock.Quantity);
            DB.AddParameter("@Barcode", NThisStock.Barcode);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStock_Update");
            //return the primary key of the new record
            //return NThisStock.StockID;
        }































    }


}
