using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSClasses
{
    public class clsStockCollection
    {


        //work

        ////create the item of test data
        //clsStock TestItem = new clsStock();
        ////set its properties
        //TestItem.StockID = 1;
        //TestItem.StockName = "a";
        //TestItem.WarehouseNo = "a";
        //TestItem.Location = "a";
        //TestItem.Quantity = "a";
        //TestItem.Barcode = "a";
        ////add the item to the test list
        //TestList.Add(TestItem);
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //private data member for the list
        List<clsStock> NStockList = new List<clsStock>();
        //public List<clsStock> StockList { get; set; }
        public int Counts { get; set; }
        public clsStock ThisStock { get; set; }


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










    }





}
