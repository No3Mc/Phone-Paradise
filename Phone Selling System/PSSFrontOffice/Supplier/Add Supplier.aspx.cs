using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;


public partial class Supplier_Add_Supplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierID"] = -1;
        Response.Redirect("Add Supplier.aspx");
        
    }

    



    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierMain.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add Supplier.aspx");
    }
}