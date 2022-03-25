using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;


namespace PSSClasses
{
    public class clsStaff
    {
        private int mStaffNo;
        private string mStaffName;
        private string mStaffEmail;
        private string mStaffPassword;
        private string mStaffTelephoneNo;
        private string mStaffPosition;


        public int StaffNo
        {
            get
            {
                //this line of code send data out of the property
                return mStaffNo;
            }
            set
            {
                //this line of code allows data into the property
                mStaffNo = value;
            }

        }

        public bool Find(int StaffNo)
        {
            //create an instance of the data connectin
            clsDataConnection DB = new clsDataConnection();
            //add the parametrs for the book to search for it
            DB.AddParameter("@StaffNo", StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");


            //if one record if found (there should either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
                mStaffPosition = Convert.ToString(DB.DataTable.Rows[0]["StaffPosition"]);
                mStaffTelephoneNo = Convert.ToString(DB.DataTable.Rows[0]["StaffTelephoneNo"]);

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

        

        public string Valid(string StaffName, string StaffEmailAddress, string StaffPassword, string StaffTelephoneNo, string StaffPosition)
        {
            //create a string variable to store the error
            String Error = "";

            //if the StaffName is blank
            if (StaffName.Length == 0)
            {
                //record the error
                Error = Error + "The staff name may not be blank : ";
            }
            //if the Staff Name is greater than 30 characters
            if (StaffName.Length > 30)
            {
                //record the error
                Error = Error + "The staff name must be less than thirty characters : ";
            }
            //is the Staff Email Address blank
            if (StaffEmailAddress.Length == 0)
            {
                //record the error
                Error = Error + "The email address may not be blank : ";
            }
            //if the Staff Email Address is too long
            if (StaffEmailAddress.Length > 50)
            {
                //record the error
                Error = Error + "The email address must be less than fifty characters : ";
            }
            //is the Staff Password blank
            if (StaffPassword.Length == 0)
            {
                //record the error
                Error = Error + "The password may not be blank : ";
            }
            //if the Staff Password is too long
            if (StaffPassword.Length > 20)
            {
                //record the error
                Error = Error + "The StaffPassword must be less than twenty characters : ";
            }
            //is the Staff Telephone No blank
            if (StaffTelephoneNo.Length == 0)
            {
                //record the error
                Error = Error + "The telephone number may not be blank : ";
            }
            //if the Staff Telephone No is too long
            if (StaffTelephoneNo.Length > 11)
            {
                //record the error
                Error = Error + "The telephone number must be less than eleven characters : ";
            }


            //is the Staff Position blank
            if (StaffPosition.Length == 0)
            {
                //record the error
                Error = Error + "The position may not be blank : ";
            }
            //return any error messages
            return Error;
        }

        public string StaffName
        {
            get
            {
                //this line of code send data out of the property
                return mStaffName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffName = value;
            }

        }


        public string StaffEmail
        {
            get
            {
                //this line of code send data out of the property
                return mStaffEmail;
            }
            set
            {
                //this line of code allows data into the property
                mStaffEmail = value;
            }

        }


        public string StaffPassword
        {
            get
            {
                //this line of code send data out of the property
                return mStaffPassword;
            }
            set
            {
                //this line of code allows data into the property
                mStaffPassword = value;
            }

        }


        public string StaffPosition
        {
            get
            {
                //this line of code send data out of the property
                return mStaffPosition;
            }
            set
            {
                //this line of code allows data into the property
                mStaffPosition = value;
            }

        }


        public string StaffTelephoneNo
        {
            get
            {
                //this line of code send data out of the property
                return mStaffTelephoneNo;
            }
            set
            {
                //this line of code allows data into the property
                mStaffTelephoneNo = value;
            }

        }



        public bool List()
        {
            //always return true
            return true;
        }
    }
}