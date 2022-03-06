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
