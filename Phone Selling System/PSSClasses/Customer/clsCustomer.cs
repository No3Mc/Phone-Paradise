using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;







namespace PSSClasses
{
    //Dbo.tblCustomer Values
    //[CustID]
    //[Address]
    //[DOB]     
    //[Name]  
    //[Email] 
    //[PhoneNo]
    public class clsCustomer
    {
        private int mCustID;
        private string mAddress;
        private string mDOB;
        private string mName;
        private string mEmail;
        private string mPhoneNo;



        public string Address
        {
            get
            {
                //this line of code send data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }

        }


        public string DOB
        {
            get
            {
                //this line of code send data out of the property
                return mDOB;
            }
            set
            {
                //this line of code allows data into the property
                mDOB = value;
            }

        }


        public string Name
        {
            get
            {
                //this line of code send data out of the property
                return mName;
            }
            set
            {
                //this line of code allows data into the property
                mName = value;
            }

        }
 

        public string Email
        {
            get
            {
                //this line of code send data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }

        }


        public string PhoneNo
        {
            get
            {
                //this line of code send data out of the property
                return mPhoneNo;
            }
            set
            {
                //this line of code allows data into the property
                mPhoneNo = value;
            }

        }

        public int CustID
        {
            get
            {
                //this line of code send data out of the property
                return mCustID;
            }
            set
            {
                //this line of code allows data into the property
                mCustID = value;
            }

        }
        public bool Find(int CustID)
        {
            //create an instance of the data connectin
            clsDataConnection DB = new clsDataConnection();
            //add the parametrs for the book to search for it
            DB.AddParameter("@CustID", CustID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByCustID");


            //if one record if found (there should either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustID = Convert.ToInt32(DB.DataTable.Rows[0]["CustID"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDOB = Convert.ToString(DB.DataTable.Rows[0]["DOB"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);

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

    }
}