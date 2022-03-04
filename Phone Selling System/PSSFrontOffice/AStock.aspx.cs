using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capute the stock name
        AStock.StockName = txtStockname.Text;
        Session["AStock"] = AStock;
        //redirect to the viewer page
        Response.Redirect("StockViewer.aspx");
    }

}