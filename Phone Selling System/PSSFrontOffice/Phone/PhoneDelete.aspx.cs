using PSSClasses.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Written by Ethan Frizzell P2596393
public partial class Phone_PhoneDelete : System.Web.UI.Page
{
    Int32 PhoneID;
    protected void Page_Load(object sender, EventArgs e)
    {
        PhoneID = Convert.ToInt32(Session["PhoneID"]); //find the PK of the record
    }

    void DeletePhone() //delete function
    {
        //create an instance of the collection class
        clsPhoneCollection PhoneBook = new clsPhoneCollection();
        //find the PK of the selected record
        PhoneBook.ThisPhone.Find(PhoneID);
        //delete the reocrd
        PhoneBook.Delete();
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeletePhone(); //delete the record
        Response.Redirect("PhoneMain.aspx"); //redirect to the main page
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("PhoneMain.aspx"); //redirect back to the main page
    }
}