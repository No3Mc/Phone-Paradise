using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DB.AddParameter("@StockName", ThisStock.StockName);
            DB.AddParameter("@WarehouseNo", ThisStock.WarehouseNo);
            DB.AddParameter("@Location", ThisStock.Location);
            DB.AddParameter("@Quantity", ThisStock.Quantity);
            DB.AddParameter("@Barcode", ThisStock.Barcode);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
            //return the primary key of the new record
            //return NThisStock.StockID;
        }

































    }


}
