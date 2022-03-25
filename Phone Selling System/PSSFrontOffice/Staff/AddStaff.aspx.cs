using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;

public partial class Staff_AddStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AStaff.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        Add();
        Response.Redirect("AStaff.aspx");
    }

    void Add()
    {
        PSSClasses.clsStaffCollection StaffList = new PSSClasses.clsStaffCollection();
        //validate the data
        String Error = StaffList.ThisStaff.Valid(txtSName.Text, txtSEmail.Text, txtSPassword.Text, txtSTelephone.Text, txtSPosition.Text);
        if (Error == "")
        {
            //get the data entered by the user
            StaffList.ThisStaff.StaffName = txtSName.Text;
            StaffList.ThisStaff.StaffEmail = txtSEmail.Text;
            StaffList.ThisStaff.StaffPassword = txtSPassword.Text;
            StaffList.ThisStaff.StaffTelephoneNo = txtSTelephone.Text;
            StaffList.ThisStaff.StaffPosition = txtSPosition.Text;
            //add the record
            StaffList.Add();
        }
        else
        {
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
   
    }