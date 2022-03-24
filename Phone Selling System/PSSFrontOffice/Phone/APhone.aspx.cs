using PSSClasses;
using PSSClasses.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Phone_APhone : System.Web.UI.Page
{
    Int32 PhoneID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first appearance of the form
        if (IsPostBack == false)
        {
            //displays phones in the list
            DisplayPhones(PhoneID);
        }
    }

    void DisplayPhones(Int32 PhoneID) //displayphones function 
    {
        //create an instance of phone class
        clsPhone MyPhoneStore = new clsPhone();
        //find record pk
        MyPhoneStore.Find(PhoneID);
        //display record data in text boxes
        txtPhoneName.Text = MyPhoneStore.PhoneName;
        txtPhoneManufacturer.Text = MyPhoneStore.PhoneManufacturer;
        txtStorageCapacity.Text = MyPhoneStore.StorageCapacity;
        txtCameraQuality.Text = MyPhoneStore.CameraQuality;
        txtBatteryCapacity.Text = MyPhoneStore.BatteryCapacity;
        txtDisplaySize.Text = MyPhoneStore.DisplaySize;
        txtDateReleased.Text = MyPhoneStore.DateReleased.ToString("dd/mm/yyyy");
        

    }

    protected void btnFind_Click(object sender, EventArgs e) //find function
    {
        //create a new instance of the phone class
        clsPhone APhone = new clsPhone();
        //variable to store the PK
        Int32 PhoneID;
        //variable to store the result of the function
        bool found = false;
        //get the PK entered
        PhoneID = Convert.ToInt32(txtPhoneID.Text);
        //find the record
        found = APhone.Find(PhoneID);
        //if the record is found
        if (found == true)
        {
            //display the values of the record in the form
            txtPhoneName.Text = APhone.PhoneName;
            txtPhoneManufacturer.Text = APhone.PhoneManufacturer;
            txtBatteryCapacity.Text = APhone.BatteryCapacity;
            txtCameraQuality.Text = APhone.CameraQuality;
            txtStorageCapacity.Text = APhone.StorageCapacity;
            txtDisplaySize.Text = APhone.DisplaySize;
            //display a message saying the record was found
            lblInfo.Text = "Record was found!";
        }
        else //if not
        {
            //display an error message saying the record was not found in the system
            lblError.Text = "Record was not found in the system";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (PhoneID == -1)
        {
            //add the new record
            AddPhone();
            //redirect to the main phone page
            Response.Redirect("PhoneMain.aspx");
        }
        else //if not
        {
            //update the record
            UpdatePhone();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e) //cancel button function
    {
        Response.Redirect("PhoneMain.aspx"); //sends user back to main page
    }

    void UpdatePhone() //update phone function
    {
        //create a new instance of the collection class
        clsPhoneCollection Phones = new clsPhoneCollection();

        //validate the data in the form
        String Error = Phones.ThisPhone.Valid(txtPhoneName.Text, txtPhoneManufacturer.Text, txtBatteryCapacity.Text, txtCameraQuality.Text, txtStorageCapacity.Text, txtDisplaySize.Text, txtDateReleased.Text);
       //get the data entered by the user
        if (Error == "")
        {
            //find the record to update using the PK
            Phones.ThisPhone.Find(PhoneID);
            //get the data entered by the user
            Phones.ThisPhone.PhoneName = txtPhoneName.Text;
            Phones.ThisPhone.PhoneManufacturer = txtPhoneManufacturer.Text;
            Phones.ThisPhone.BatteryCapacity = txtBatteryCapacity.Text;
            Phones.ThisPhone.CameraQuality = txtCameraQuality.Text;
            Phones.ThisPhone.StorageCapacity = txtStorageCapacity.Text;
            Phones.ThisPhone.DisplaySize = txtDisplaySize.Text;
            Phones.ThisPhone.DateReleased = Convert.ToDateTime(txtDateReleased.Text);
            //update the record
            Phones.Update();
            //redirect back to the main page
            Response.Redirect("PhoneMain.aspx");
        }
        else //if not
        {
            //notify the user that errors have occurred
            lblError.Text = "The follwoing issues occurred..." + Error;
        }
    }

    void AddPhone()
    {
        //create a new instance of the collection class
        clsPhoneCollection Phones = new clsPhoneCollection();

        //validate the data in the form
        String Error = Phones.ThisPhone.Valid(txtPhoneName.Text, txtPhoneManufacturer.Text, txtBatteryCapacity.Text, txtCameraQuality.Text, txtStorageCapacity.Text, txtDisplaySize.Text, txtDateReleased.Text);
        //if there are no errors
        if (Error == "")
        {

            
            //get the data entered by the user
            Phones.ThisPhone.PhoneName = txtPhoneName.Text;
            Phones.ThisPhone.PhoneManufacturer = txtPhoneManufacturer.Text;
            Phones.ThisPhone.BatteryCapacity = txtBatteryCapacity.Text;
            Phones.ThisPhone.CameraQuality = txtCameraQuality.Text;
            Phones.ThisPhone.StorageCapacity = txtStorageCapacity.Text;
            Phones.ThisPhone.DisplaySize = txtDisplaySize.Text;
            Phones.ThisPhone.DateReleased = Convert.ToDateTime(txtDateReleased.Text);
            //add the reocrd
            Phones.Add();
            //redirect back to the main page
            Response.Redirect("PhoneMain.aspx");
        }
        else //if not
        {
            //inform the user of the occurring errors
            lblError.Text = "The follwoing issues occurred..." + Error;
        }
    }

    protected void lstPhones_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}