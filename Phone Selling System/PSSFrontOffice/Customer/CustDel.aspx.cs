using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;
//Done by Memon
public partial class Customer_CustDel : System.Web.UI.Page
{
    Int32 CustID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustID = Convert.ToInt32(Session["CustID"]);
    }
    void DeleteCustomer()
    {
        //function to delete the selected record
        //create a new instance of the Customer Book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //fiind the record to Delete
        CustomerBook.ThisCust.Find(CustID);
        //Delete teh record
        CustomerBook.Delete();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Delete the customer record
        DeleteCustomer();
        Response.Redirect("Custpg.aspx");
    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Custpg.aspx");
    }

}