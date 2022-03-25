using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Stock/StockViewer.aspx");

    }

    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Default.aspx");

    }



    

    protected void Button11_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierMain.aspx");
    }
}