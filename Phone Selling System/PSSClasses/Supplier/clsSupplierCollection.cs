using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSClasses
{

    public class clsSupplierCollection
    {



        //private data member for the list
        List<clsSupplier> aSupplierList = new List<clsSupplier>();
        public int Counts { get; set; }
        clsSupplier aThisSupplier = new clsSupplier();
        public int Add()
        {
            //adds a new record to the database based on the values
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", aThisSupplier.Name);
            DB.AddParameter("@Address", aThisSupplier.Address);
            DB.AddParameter("@MobileNo", aThisSupplier.MobileNo);
            DB.AddParameter("@Email", aThisSupplier.Email);
            DB.AddParameter("@DOB", aThisSupplier.DOB);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblSupplier_Insert");

        }
        public clsSupplier ThisSupplier
        {
            get
            {
                //return the private data
                return aThisSupplier;
            }
            set
            {
                //set private data
                aThisSupplier = value;
            }
        }


        public List<clsSupplier> SupplierList
        {
            get
            {
                //return the private data
                return aSupplierList;
            }
            set
            {
                //set the private data
                aSupplierList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return aSupplierList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }


        public clsSupplierCollection()
        {

            //objcet for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);

        }

        public void Update()
        {
            //adds a new record to the database based on the values
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", aThisSupplier.SupplierID);
            DB.AddParameter("@Name", aThisSupplier.Name);
            DB.AddParameter("@Address", aThisSupplier.Address);
            DB.AddParameter("@MobileNo", aThisSupplier.MobileNo);
            DB.AddParameter("@Email", aThisSupplier.Email);
            DB.AddParameter("@DOB", aThisSupplier.DOB);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblSupplier_Update");

        }

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
            aSupplierList = new List<clsSupplier>();
            //while there are records to process
            while (Index < RecordsCount)
            {
                //create a blank book
                clsSupplier aSupplier = new clsSupplier();
                //read in the fields from the current records
                aSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                aSupplier.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                aSupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                aSupplier.MobileNo = Convert.ToString(DB.DataTable.Rows[Index]["MobileNo"]);
                aSupplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                aSupplier.DOB = Convert.ToString(DB.DataTable.Rows[Index]["DOB"]);



                //add the record to the private data member
                aSupplierList.Add(aSupplier);
                //point at the record
                Index++;
            }
        }


        public void Delete()
        {
            //delete the record pointed by the thisStock
            //connects database
            clsDataConnection DB = new clsDataConnection();
            //parameters for the stored procedure
            DB.AddParameter("@SupplierID", aThisSupplier.SupplierID);
            //execute the stored procedure 
            DB.Execute("sproc_tblSupplier_Del");
        }







































    }
}
