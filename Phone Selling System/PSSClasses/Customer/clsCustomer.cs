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




        public string Valid(int CustID, string PhoneNo, string Address, string DOB, string Name, string Email)
        {
            //create a string variable to store the error
            String Error = "";


            //if the PhoneNo is blank
            if (PhoneNo.Length == 0)
            {
                //record the error
                Error = Error + "The house no may not be blank : ";
            }
            //if the PhoneNo is greater than 6 characters
            if (PhoneNo.Length > 50)
            {
                //record the error
                Error = Error + "The house no must be less than 6 characters : ";
            }
            //is the Address blank
            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the Address is too long
            if (Address.Length > 50)
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
            }
            //is the DOB blank
            if (DOB.Length == 0)
            {
                //record the error
                Error = Error + "The street may not be blank : ";
            }
            //if the DOB is too long
            if (DOB.Length > 50)
            {
                //record the error
                Error = Error + "The street must be less than 50 characters : ";
            }
            //is the Name blank
            if (Name.Length == 0)
            {
                //record the error
                Error = Error + "The town may not be blank : ";
            }
            //if the Name is too long
            if (Name.Length > 50)
            {
                //record the error
                Error = Error + "The town must be less than 50 characters : ";
            }


            //is the Email blank
            if (Email.Length == 0)
            {
                //record the error
                Error = Error + "The town may not be blank : ";
            }
            //if the Email is too long
            if (Email.Length > 50)
            {
                //record the error
                Error = Error + "The town must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5)
        {
            throw new NotImplementedException();
        }

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
            //add the parametrs for the customer to search for it
            DB.AddParameter("@CustID", CustID);
            //execute the stored procedure
            DB.Execute("sproc_tblCust_FilterByCustID");


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