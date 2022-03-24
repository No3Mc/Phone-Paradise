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
        //staffNo private member variable 
        private Int32 mStaffNo;
        public Int32 StaffNo 
        {
            get
            {
                return mStaffNo;
            }
            set
            {
                mStaffNo = value;
            }
        }

        //staffName private member variable
        private string mStaffName;
        public string StaffName { get { return mStaffName; } set { mStaffName = value; } }

        //staffEmail private member variable
        private string mStaffEmailAddress;
        public string StaffEmailAddress { get { return mStaffEmailAddress; } set { mStaffEmailAddress = value; } }

        //staff password private member variable
        private string mStaffPassword;
        public string StaffPassword { get { return mStaffPassword; } set { mStaffPassword = value; } }

        //staffPosition private member vaule
        private string mStaffPosition;
        public string StaffPosition { get { return mStaffPosition; } set { mStaffPosition = value; } }

        //staff telephone private member variable
        private string mStaffTelephoneNo;
        public string StaffTelephoneNo { get { return mStaffTelephoneNo; } set { mStaffTelephoneNo = value; } }

        public bool Find(int staffNo)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffNo", StaffNo);

            DB.Execute("sproc_tblStaff_FilterbyStaffNo");

            if (DB.Count == 1)
            {
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
                mStaffPosition = Convert.ToString(DB.DataTable.Rows[0]["StaffPosition"]);
                mStaffTelephoneNo = Convert.ToString(DB.DataTable.Rows[0]["StaffTelephoneNo"]);

                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Find(string staffName)
        {
            //always return true
            return true;
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


            //is the StaffPosition blank
            if (StaffPosition.Length == 0)
            {
                //record the error
                Error = Error + "The position may not be blank : ";
            }
            //return any error messages
            return Error;
        }

        public bool List()
        {
            //always return true
            return true;
        }
    }
}