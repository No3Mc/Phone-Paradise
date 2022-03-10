using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;


public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer id
        ACustomer.Name = txtName.Text;
        //store the name in the session object
        Session["ACustomer"] = ACustomer;
        //redirect to the viwer page
        Response.Redirect("CustomerViewer.aspx");

    }
}