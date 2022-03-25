using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;

public partial class Staff_DeleteStaff : System.Web.UI.Page
{
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    void DeleteStaff()
    {
        //function to delete the selected record
        clsStaffCollection StaffList = new clsStaffCollection();
        //fiind the record to remove
        StaffList.ThisStaff.Find(StaffNo);
        //del teh record
        StaffList.Del();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        DeleteStaff();
        Response.Redirect("AStaff.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("AStaff.aspx");
    }
}