using System;

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
    }
}