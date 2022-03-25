using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;

public partial class Staff_StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the staff name of this entry
        Response.Write(AStaff.StaffName);
        Response.Write(AStaff.StaffTelephoneNo);
        Response.Write(AStaff.StaffPassword);
        Response.Write(AStaff.StaffEmail);
        Response.Write(AStaff.StaffPosition);
    }
}