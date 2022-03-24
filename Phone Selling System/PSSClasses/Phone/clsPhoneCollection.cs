using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSClasses.Phone
{
    public class clsPhoneCollection
    {

        List<clsPhone> mPhoneList = new List<clsPhone>();

        public int Count { get; set; }
        clsPhone mThisPhone = new clsPhone();

        public clsPhone ThisPhone
        {
            get
            {
                return mThisPhone;
            }
            set
            {
                mThisPhone = value;
            }
        }

        public List<clsPhone> PhoneList
        {
            get
            {
                return mPhoneList;
            }
            set
            {
                mPhoneList = value;
            }
        }

        

        public clsPhoneCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblPhone_SelectAll");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;

            int RecordsCount = 0;

            RecordsCount = DB.Count;

            mPhoneList = new List<clsPhone>();

            while (Index < RecordsCount)
            {
                clsPhone APhone = new clsPhone();

                APhone.PhoneID = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneID"]);
                APhone.PhoneName = Convert.ToString(DB.DataTable.Rows[Index]["PhoneName"]);
                APhone.PhoneManufacturer = Convert.ToString(DB.DataTable.Rows[Index]["PhoneManufacturer"]);
                APhone.BatteryCapacity = Convert.ToString(DB.DataTable.Rows[Index]["BatteryCapacity"]);
                APhone.CameraQuality = Convert.ToString(DB.DataTable.Rows[Index]["CameraQuality"]);
                APhone.StorageCapacity = Convert.ToString(DB.DataTable.Rows[Index]["StorageCapacity"]);
                APhone.DisplaySize = Convert.ToString(DB.DataTable.Rows[Index]["DisplaySize"]);
                APhone.DateReleased = Convert.ToDateTime(DB.DataTable.Rows[Index]["Datereleased"]);


                mPhoneList.Add(APhone);

                Index++;
            }
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("@PhoneID", mThisPhone.PhoneID);
            
            DB.Execute("sproc_tblPhone_Delete");
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PhoneName", mThisPhone.PhoneName);
            DB.AddParameter("@PhoneManufacturer", mThisPhone.PhoneManufacturer);
            DB.AddParameter("@BatteryCapacity", mThisPhone.BatteryCapacity);
            DB.AddParameter("@CameraQuality", mThisPhone.CameraQuality);
            DB.AddParameter("@StorageCapacity", mThisPhone.StorageCapacity);
            DB.AddParameter("@DisplaySize", mThisPhone.DisplaySize);
            DB.AddParameter("@DateReleased", mThisPhone.DateReleased);

            return DB.Execute("sproc_tblPhone_Add");
            
        }

        public void Update()
        {
            
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PhoneID", mThisPhone.PhoneID);
            DB.AddParameter("@PhoneName", mThisPhone.PhoneName);
            DB.AddParameter("@PhoneManufacturer", mThisPhone.PhoneManufacturer);
            DB.AddParameter("@BatteryCapacity", mThisPhone.BatteryCapacity);
            DB.AddParameter("@CameraQuality", mThisPhone.CameraQuality);
            DB.AddParameter("@StorageCapacity", mThisPhone.StorageCapacity);
            DB.AddParameter("@DisplaySize", mThisPhone.DisplaySize);
            DB.AddParameter("@DateReleased", mThisPhone.DateReleased);

            DB.Execute("sproc_tblStock_Update");

            
            
        }

        public void FilterByName(string PhoneName)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PhoneName", PhoneName);

            DB.Execute("sproc_tblPhone_FilterByName");
        }
    }
}
