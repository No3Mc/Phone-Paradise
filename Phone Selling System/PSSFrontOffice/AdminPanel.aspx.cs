using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Written by Syed, Ethan, Talha, Luke, and Aqeel || P2652259|| Syed/No3Mc(https://github.com/No3Mc),  P2596393 || Ethan/Frizzle15(https://github.com/Frizzle15), P2629099 || Talha(https://github.com/Talhamemon25), P2606530 || Luke/LLydiatt(https://github.com/LLydiatt)and Aqeel(https://github.com/AqeelAhmed12))

//Stock Management by Syed Naqvi
//Staff Management by Luke Lydiatt
//Phones Management by Ethan Frizzell
//Customer Management by Mahammad Talha
//Supplier management by Aqeel Ahmed	


//Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store
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

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("PhoneMain.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("APhone.aspx");
    }
}