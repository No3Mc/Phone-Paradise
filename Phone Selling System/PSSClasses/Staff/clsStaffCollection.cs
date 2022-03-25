
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSClasses
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        public int Counts { get; set; }
        clsStaff mThisStaff = new clsStaff();


        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set private data
                mThisStaff = value;
            }
        }


        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }


        public clsStaffCollection()
        {

            //objcet for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);

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
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordsCount)
            {
                //create a blank book
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current records
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffPassword = Convert.ToString(DB.DataTable.Rows[Index]["StaffPassword"]);
                AStaff.StaffPosition = Convert.ToString(DB.DataTable.Rows[Index]["StaffPosition"]);
                AStaff.StaffTelephoneNo = Convert.ToString(DB.DataTable.Rows[Index]["StaffTelephoneNo"]);






                //add the record to the private data member
                mStaffList.Add(AStaff);
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
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_Delete");
        }


        public int Add()
        {
            //adds a new record to the database based on the values
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@StaffPosition", mThisStaff.StaffPosition);
            DB.AddParameter("@StaffTelephoneNo", mThisStaff.StaffTelephoneNo);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }


        public void Update()
        {
            //adds a new record to the database based on the values
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@StaffPosition", mThisStaff.StaffPosition);
            DB.AddParameter("@StaffTelephoneNo", mThisStaff.StaffTelephoneNo);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}