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
        String StaffName = txtSName.Text;
        String StaffEmailAddress = txtSEmail.Text;
        String StaffPassword = txtSPassword.Text;
        String StaffPosition = txtSPos.Text;
        String StaffTelephoneNo = txtSPhone.Text;
        //validate the data on the web form
        String Error = ""; 
        Error = AStaff.Valid(StaffName, StaffEmailAddress, StaffPassword, StaffTelephoneNo, StaffPosition);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            AStaff.StaffName = StaffName;
            AStaff.StaffEmailAddress = StaffEmailAddress;
            AStaff.StaffPassword = StaffPassword;
            AStaff.StaffTelephoneNo = StaffTelephoneNo;
            AStaff.StaffPosition = StaffPosition;
            //all done so redirect back to main page
            Response.Redirect("AStaff.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems" + Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffNo;
        //variable to store the result of the find operation
        bool found = false;
        //get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //find the record
        found = AStaff.Find(StaffNo);
        //if found
        if (found == true)
        {

            //display the values of the properties in the form
            txtSName.Text = AStaff.StaffName;
            txtSEmail.Text = AStaff.StaffEmailAddress;
            txtSPassword.Text = AStaff.StaffPassword;
            txtSPos.Text = AStaff.StaffPosition;
            txtSPhone.Text = AStaff.StaffTelephoneNo;

            lblError.Text = " found";
        }
        else
        {
            //display the error msg
            lblError.Text = "Not found";
        }
    }
}