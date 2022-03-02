using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        AStock = (clsStock)Session["AStock"];
        Response.Write(AStock.StockName);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsStock AStock = new clsStock();
        //capture the name
        AStock.StockName = txtStock.Text;
        //Store address in session object
        Session["AStock"] = AStock;
        //redirect to viewer page
        Response.Redirect("SupplierViewer.aspx");

    }

}

