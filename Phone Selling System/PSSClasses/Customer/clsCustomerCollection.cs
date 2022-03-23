
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PSSClasses
{
    public class clsCustomerCollection
    {


       
            //private data member for the list
            List<clsCustomer> mCustList = new List<clsCustomer>();
            public int Counts { get; set; }
            clsCustomer mThisCust = new clsCustomer();
            public int Add()
            {
                //adds a new record to the database based on the values
                //set the primary key value of the new record
                clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustID", mThisCust.CustID);
            DB.AddParameter("@PhoneNo", mThisCust.PhoneNo);
                DB.AddParameter("@Address", mThisCust.Address);
                DB.AddParameter("@DOB", mThisCust.DOB);
                DB.AddParameter("@Name", mThisCust.Name);
                DB.AddParameter("@Email", mThisCust.Email);
                //execute the query returning the primary key value
                return DB.Execute("sproc_tblCust_Insert");

            }
            public clsCustomer ThisCust
            {
                get
                {
                    //return the private data
                    return mThisCust;
                }
                set
                {
                    //set private data
                    mThisCust = value;
                }
            }


            public List<clsCustomer> CustList
            {
                get
                {
                    //return the private data
                    return mCustList;
                }
                set
                {
                    //set the private data
                    mCustList = value;
                }
            }

            public int Count
            {
                get
                {
                    //return the count of the list
                    return mCustList.Count;
                }
                set
                {
                    //we shall worry about this later
                }
            }


            public clsCustomerCollection()
            {

                //objcet for data connection
                clsDataConnection DB = new clsDataConnection();
                //execute the stored procedure
                DB.Execute("sproc_tblCust_SelectAll");
                //populate the array list with data table
                PopulateArray(DB);

            }

            public void Update()
            {
                //adds a new record to the database based on the values
                //set the primary key value of the new record
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@CustID", mThisCust.CustID);
                DB.AddParameter("@PhoneNo", mThisCust.PhoneNo);
                DB.AddParameter("@Address", mThisCust.Address);
                DB.AddParameter("@DOB", mThisCust.DOB);
                DB.AddParameter("@Name", mThisCust.Name);
                DB.AddParameter("@Email", mThisCust.Email);
                //execute the query returning the primary key value
                DB.Execute("sproc_tblCust_Update");

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
                mCustList = new List<clsCustomer>();
                //while there are records to process
                while (Index < RecordsCount)
                {
                    //create a blank book
                    clsCustomer AnCustomer = new clsCustomer();
                    //read in the fields from the current records
                    AnCustomer.CustID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustID"]);
                    AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                    AnCustomer.DOB = Convert.ToString(DB.DataTable.Rows[Index]["DOB"]);
                    AnCustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                    AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                    AnCustomer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);



                    //add the record to the private data member
                    mCustList.Add(AnCustomer);
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
                DB.AddParameter("@CustID", mThisCust.CustID);
                //execute the stored procedure 
                DB.Execute("sproc_tblCust_Delete");
            }

            public void ReportByName(string Name)
            {
                //filter the records based on a full or partial title
                //connect to the DB
                clsDataConnection DB = new clsDataConnection();
                //send the title parameter to the DB
                DB.AddParameter("@Name", Name);
                //execute the stored procedure
                DB.Execute("sproc_tblCust_FilterByName");
                //populate the array list with the data table
                PopulateArray(DB);
            }





































        }
    }

















