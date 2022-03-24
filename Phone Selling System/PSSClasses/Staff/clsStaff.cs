using System;

namespace PSSClasses
{
    public class clsStaff
    {
        public string StaffName { get; set; }
        public string StaffEmailAddress { get; set; }
        public string StaffPassword { get; set; }
        public string StaffPosition { get; set; }
        public int StaffTelephoneNo { get; set; }

        public bool Find(string staffName)
        {
            //always return true
            return true;
        }
    }
}