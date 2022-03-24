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

    void DisplayPhones(Int32 PhoneID)
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        
        clsPhone APhone = new clsPhone();
        
        Int32 PhoneID;
        
        bool found = false;
        
        PhoneID = Convert.ToInt32(txtPhoneID.Text);
        
        found = APhone.Find(PhoneID);
        
        if (found == true)
        {
            
            txtPhoneName.Text = APhone.PhoneName;
            txtPhoneManufacturer.Text = APhone.PhoneManufacturer;
            txtBatteryCapacity.Text = APhone.BatteryCapacity;
            txtCameraQuality.Text = APhone.CameraQuality;
            txtStorageCapacity.Text = APhone.StorageCapacity;
            txtDisplaySize.Text = APhone.DisplaySize;

            lblInfo.Text = "Record was found!";
        }
        else
        {
            //display the error msg
            lblError.Text = "Record was not found in the system";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (PhoneID == -1)
        {
            
            AddPhone();
            
            Response.Redirect("PhoneMain.aspx");
        }
        else
        {
            
            UpdatePhone();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("PhoneMain.aspx");
    }

    void UpdatePhone()
    {
        
        clsPhoneCollection Phones = new clsPhoneCollection();

        
        String Error = Phones.ThisPhone.Valid(txtPhoneName.Text, txtPhoneManufacturer.Text, txtBatteryCapacity.Text, txtCameraQuality.Text, txtStorageCapacity.Text, txtDisplaySize.Text, txtDateReleased.Text);
       
        if (Error == "")
        {
            
            Phones.ThisPhone.Find(PhoneID);
            
            Phones.ThisPhone.PhoneName = txtPhoneName.Text;
            Phones.ThisPhone.PhoneManufacturer = txtPhoneManufacturer.Text;
            Phones.ThisPhone.BatteryCapacity = txtBatteryCapacity.Text;
            Phones.ThisPhone.CameraQuality = txtCameraQuality.Text;
            Phones.ThisPhone.StorageCapacity = txtStorageCapacity.Text;
            Phones.ThisPhone.DisplaySize = txtDisplaySize.Text;
            Phones.ThisPhone.DateReleased = Convert.ToDateTime(txtDateReleased.Text);
            
            Phones.Update();
            
            Response.Redirect("PhoneMain.aspx");
        }
        else
        {
            
            lblError.Text = "The follwoing issues occurred..." + Error;
        }
    }

    void AddPhone()
    {

        clsPhoneCollection Phones = new clsPhoneCollection();


        String Error = Phones.ThisPhone.Valid(txtPhoneName.Text, txtPhoneManufacturer.Text, txtBatteryCapacity.Text, txtCameraQuality.Text, txtStorageCapacity.Text, txtDisplaySize.Text, txtDateReleased.Text);

        if (Error == "")
        {

            

            Phones.ThisPhone.PhoneName = txtPhoneName.Text;
            Phones.ThisPhone.PhoneManufacturer = txtPhoneManufacturer.Text;
            Phones.ThisPhone.BatteryCapacity = txtBatteryCapacity.Text;
            Phones.ThisPhone.CameraQuality = txtCameraQuality.Text;
            Phones.ThisPhone.StorageCapacity = txtStorageCapacity.Text;
            Phones.ThisPhone.DisplaySize = txtDisplaySize.Text;
            Phones.ThisPhone.DateReleased = Convert.ToDateTime(txtDateReleased.Text);

            Phones.Add();

            Response.Redirect("PhoneMain.aspx");
        }
        else
        {

            lblError.Text = "The follwoing issues occurred..." + Error;
        }
    }

    protected void lstPhones_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}