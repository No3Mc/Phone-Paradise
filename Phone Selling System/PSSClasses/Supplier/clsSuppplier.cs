using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace PSSClasses
    {

        public class clsSupplier
        {
            private int aSupplierID;
            private string aName;
            private string aAddress;
            private string aMobileNo;
            private string aEmail;
            private string aDOB;
            public string EmailAddress;

            public string Valid(string Name, string Address, string MobileNo, string Email, string DOB, int SupplierID)
            {
                //create a string variable to store the error
                String Error = "";




                //If the Name is blank
                if (Name.Length == 0)
                {
                    //Show the error
                    Error = Error + "The Name can not be blank : ";
                }
                //if the Name is too long
                if (Name.Length > 25)
                {
                    //record the error
                    Error = Error + "The Name must be less than 25 characters : ";
                }
                //is the Address is blank
                if (Address.Length == 0)
                {
                    //Show the error
                    Error = Error + "The Address can not be blank : ";
                }
                //if the Address is too long
                if (Address.Length > 10)
                {
                    //record the error
                    Error = Error + "The  Address must be less than 10 characters : ";
                }
                //if the Mobile no is blank
                if (MobileNo.Length == 0)
                {
                    //Show the error
                    Error = Error + "MobileNo can not be blank : ";
                }
                //if the Mobile no is greater than 6 characters
                if (MobileNo.Length > 12)
                {
                    //Show the error
                    Error = Error + "The MobileNo must be less than 12 characters : ";
                }
                //if the email is blank
                if (Email.Length == 0)
                {
                    //Show the error
                    Error = Error + "The Email may not be blank : ";
                }
                //if the town is too long
                if (Email.Length > 40)
                {
                    //Email the error
                    Error = Error + "The Email must be less than 40 characters : ";
                }
                //If the DOB is blank
                if (DOB.Length == 0)
                {
                    //Show the error
                    Error = Error + "The DOB may not be blank : ";
                }
                //if the DOB is too long
                if (DOB.Length > 6)
                {
                    //Show the error
                    Error = Error + "The DOB must be less than 6 characters : ";
                }
                //return any error messages
                return Error;
            }
            public int SupplierID
            {
                get
                {
                    //this line of code send data out of the property
                    return aSupplierID;
                }
                set
                {
                    //this line of code allows data into the property
                    aSupplierID = value;
                }

            }
            public string Name
            {
                get
                {
                    //this line of code send data out of the property
                    return aName;
                }
                set
                {
                    //this line of code allows data into the property
                    aName = value;
                }

            }
            public string Address
            {
                get
                {
                    //this line of code send data out of the property
                    return aAddress;
                }
                set
                {
                    //this line of code allows data into the property
                    aAddress = value;
                }

            }
            public string MobileNo
            {
                get
                {
                    //this line of code send data out of the property
                    return aMobileNo;
                }
                set
                {
                    //this line of code allows data into the property
                    aMobileNo = value;
                }

            }
            public string Email
            {
                get
                {
                    //this line of code send data out of the property
                    return aEmail;
                }
                set
                {
                    //this line of code allows data into the property
                    aEmail = value;
                }

            }
            public string DOB
            {
                get
                {
                    //this line of code send data out of the property
                    return aDOB;
                }
                set
                {
                    //this line of code allows data into the property
                    aDOB = value;
                }

            }

            public DateTime DateAdded { get; set; }
            public string PhoneNumber { get; set; }

           

            public bool Find(int supplierID)
            {
                //create an instance of the data connectin
                clsDataConnection DB = new clsDataConnection();
                //add the parametrs for the book to search for it
                DB.AddParameter("@SupplierID",supplierID);
                //execute the stored procedure
                DB.Execute("sproc_Supplier_FilterBySupplierID");


                //if one record if found (there should either one or zero)
                if (DB.Count == 1)
                {
                    //copy the data from the database to the private data members
                    aSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                    aName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                    aAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                    aMobileNo = Convert.ToString(DB.DataTable.Rows[0]["MobileNo"]);
                    aEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                    aDOB = Convert.ToString(DB.DataTable.Rows[0]["DOB"]);
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


