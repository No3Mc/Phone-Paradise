using PSSClasses.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Phone_PhoneDelete : System.Web.UI.Page
{
    Int32 PhoneID;
    protected void Page_Load(object sender, EventArgs e)
    {
        PhoneID = Convert.ToInt32(Session["PhoneID"]);
    }

    void DeletePhone()
    {
        clsPhoneCollection PhoneBook = new clsPhoneCollection();
        PhoneBook.ThisPhone.Find(PhoneID);
        PhoneBook.Delete();
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeletePhone();
        Response.Redirect("PhoneMain.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("PhoneMain.aspx");
    }
}