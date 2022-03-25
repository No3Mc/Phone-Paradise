using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff_MainStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddStaff.aspx");
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditStaff.aspx");
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteStaff.aspx");
    }
}