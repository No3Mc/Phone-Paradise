using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;
public partial class Supplier_FindSupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }





    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsSupplier anSupplier = new clsSupplier();
        //variable to store the primary key
        Int32 SupplierID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary kev entered by the user
        SupplierID = Convert.ToInt32(SID.Text);
        //find the record
        Found = anSupplier.Find(SupplierID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            SID.Text = anSupplier.SupplierID.ToString();
            SName.Text = anSupplier.Name;
            SAddress.Text = anSupplier.Address;
            SMobileNo.Text = anSupplier.MobileNo;
            SEmail.Text = anSupplier.Email;
            SDOB.Text = anSupplier.DOB;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierMain.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FindSupplier.aspx");
    }
}