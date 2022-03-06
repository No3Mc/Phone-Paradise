using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSClasses
{
    public class clsStockCollection
    {
        public List<clsStock> StockList { get; set; }
        public int Counts { get; set; }
        public clsStock ThisStock { get; set; }
    }
}
