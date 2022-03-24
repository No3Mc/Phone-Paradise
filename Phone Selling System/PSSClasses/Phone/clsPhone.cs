using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSClasses
{

    //Dbo.tblPhone
    
    public class clsPhone
    {
        private int mPhoneID;
        private string mPhoneName;
        private string mPhoneManufacturer;
        private string mBatteryCapacity;
        private string mCameraQuality;
        private string mStorageCapacity;
        private string mDisplaySize;
        private DateTime mDateReleased;

        public int PhoneID
        {
            get
            {
                return mPhoneID;
            }
            set
            {
                mPhoneID = value;
            }
        }

        public bool Find(Int32 PhoneID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PhoneID", PhoneID);

            DB.Execute("sproc_tblPhone_FilterByPhoneID");

            if (DB.Count == 1)
            {
                mPhoneID = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneID"]);
                mPhoneName = Convert.ToString(DB.DataTable.Rows[0]["PhoneName"]);
                mBatteryCapacity = Convert.ToString(DB.DataTable.Rows[0]["BatteryCapacity"]);
                mCameraQuality = Convert.ToString(DB.DataTable.Rows[0]["CameraQuality"]);
                mStorageCapacity = Convert.ToString(DB.DataTable.Rows[0]["StorageCapacity"]);
                mDisplaySize = Convert.ToString(DB.DataTable.Rows[0]["DisplaySize"]);
                mDateReleased = Convert.ToDateTime(DB.DataTable.Rows[0]["DateReleased"]);

                return true;
            }

            else
            {
                return false;
            }
        }
    

    public string Valid(string PhoneName, string PhoneManufacturer, string BatteryCapacity,
        string CameraQuality, string StorageCapacity, string DisplaySize, string DateReleased)
    {
        String Error = "";

        if (PhoneName.Length == 0)
        {
            Error = Error + "The Phone Name may not be blank";
        }

        if (PhoneName.Length > 40)
        {
            Error = Error + "The Phone Name can't be more than 40 characters";
        }

        if (PhoneManufacturer.Length == 0)
        {
            Error = Error + "The Phone Manufacturer may not be blank";
        }

        if (PhoneManufacturer.Length > 40)
        {
            Error = Error + "The Phone Manufacturer can't be more than 40 characters";
        }

        if (BatteryCapacity.Length == 0)
        {
            Error = Error + "The Battery Capacity may not be blank";
        }

        if (BatteryCapacity.Length > 7)
        {
            Error = Error + "The Battery Capacity can't be more than 7 characters";
        }

        if (CameraQuality.Length == 0)
        {
            Error = Error + "The Camera Quality may not be blank";
        }

        if (CameraQuality.Length > 5)
        {
            Error = Error + "The Camera Quality can't be more than 5 characters";
        }

        if (StorageCapacity.Length == 0)
        {
            Error = Error + "The Storage Capacity may not be blank";
        }

        if (StorageCapacity.Length > 5)
        {
            Error = Error + "The Storage Capacity can't be more than 5 characters";
        }

        if (DisplaySize.Length == 0)
        {
            Error = Error + "The Display Size may not be blank";
        }

        if (DisplaySize.Length > 5)
        {
            Error = Error + "The Display Size can't be more than 5 characters";
        }



            //test to see if date value is valid
            try

            {
                //variable to store the date data type
                DateTime Temp;
                //convert data so that it i usable 
                Temp = Convert.ToDateTime(DateReleased);
            }
            catch //if fails
            {
                //set the error messsage
                Error = "Date added is not valid. ";
            }

            if (Error == "")
            {
                //blank string 
                return "";
            }
            else //if not
            {
                //return error message
                return "There were the following errors : " + Error;
            }
            
    }

        public string PhoneName
    {
        get
        {
            return mPhoneName;
        }

        set
        {
            mPhoneName = value;
        }
    }

        public string PhoneManufacturer
        {
            get
            {
                return mPhoneManufacturer;
            }

            set
            {
                mPhoneManufacturer = value;
            }
        }

        public string BatteryCapacity
        {
            get
            {
                return mBatteryCapacity;
            }

            set
            {
                mBatteryCapacity = value;
            }
        }

        public string CameraQuality
        {
            get
            {
                return mCameraQuality;
            }

            set
            {
                mCameraQuality = value;
            }
        }

        public string StorageCapacity
        {
            get
            {
                return mStorageCapacity;
            }

            set
            {
                mStorageCapacity = value;
            }
        }

        public string DisplaySize
        {
            get
            {
                return mDisplaySize;
            }

            set
            {
                mDisplaySize = value;
            }

            
        }

        public DateTime DateReleased
        { 
            get
            {
                return mDateReleased;
            }
            set
            {
                mDateReleased = value;
            }
        }
    }
}
