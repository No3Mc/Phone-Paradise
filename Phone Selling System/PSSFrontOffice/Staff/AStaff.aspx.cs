using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;

public partial class Staff_AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the Staff Details
        AStaff.StaffName = txtSName.Text;
        AStaff.StaffEmailAddress = txtSEmail.Text;
        AStaff.StaffPassword = txtSPassword.Text;
        AStaff.StaffPosition = txtSPos.Text;
        AStaff.StaffTelephoneNo = Convert.ToInt32(txtSPhone.Text);
        //store the name in the session object
        Session["AStaff"] = AStaff;
        //redirect to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }
}