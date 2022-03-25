using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;
public partial class Staff_AStaff : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
            DisplayStaff();
    }

    void DisplayStaff()
    {
        //create an instance of the Stock collection
        PSSClasses.clsStaffCollection AStaff = new PSSClasses.clsStaffCollection();
        //set the data source to the find the staff
        lstStaff.DataSource = AStaff.StaffList;
        //set the name of the primary key
        lstStaff.DataValueField = "StaffNo";
        //set the data field to display
        lstStaff.DataTextField = "StaffName";
        //bind the data to the list
        lstStaff.DataBind();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //update the record
        Update();
/*        //add the new record
        Add();
        //all done so redirect back to main page
        //Response.Redirect("AddStaff.aspx");*/

    }

    //function for adding new records
    void Add()
    {
        PSSClasses.clsStaffCollection Staff = new PSSClasses.clsStaffCollection();

        //validate the data on the web form
        string Error = Staff.ThisStaff.Valid(txtSEmail.Text, txtSName.Text, txtSPassword.Text, txtSPos.Text, txtSPhone.Text);
        //if the data is Ok then add it to the object
        if (Error == "")
        {
            //find the record to update
            Staff.ThisStaff.Find(StaffNo);
            //get the data entered by the user
            Staff.ThisStaff.StaffEmail = txtSEmail.Text;
            Staff.ThisStaff.StaffName = txtSName.Text;
            Staff.ThisStaff.StaffPassword = txtSPassword.Text;
            Staff.ThisStaff.StaffPosition = txtSPos.Text;
            Staff.ThisStaff.StaffTelephoneNo = txtSPhone.Text;
            //add the record
            Staff.Add();
            //all done so redirect back to the main page
            Response.Redirect("AStaff.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems " + Error;
        }
    }

    void Update()
    {
        PSSClasses.clsStaffCollection Staff = new PSSClasses.clsStaffCollection();

        //validate the data on the web form
        string Error = Staff.ThisStaff.Valid(txtSEmail.Text, txtSName.Text, txtSPassword.Text, txtSPos.Text, txtSPhone.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            Staff.ThisStaff.Find(StaffNo);
            //get the data entered by the user
            Staff.ThisStaff.StaffEmail = txtSEmail.Text;
            Staff.ThisStaff.StaffName = txtSName.Text;
            Staff.ThisStaff.StaffPassword = txtSPassword.Text;
            Staff.ThisStaff.StaffPosition = txtSPos.Text;
            Staff.ThisStaff.StaffTelephoneNo = txtSPhone.Text;
            //update the record
            Staff.Update();
            //all done so redirect back to main page
            Response.Redirect("AStaff.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems" + Error;
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        //all done so redirect back to main page
        //Response.Redirect("AddStaff.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
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
            txtSEmail.Text = AStaff.StaffEmail;
            txtSName.Text = AStaff.StaffName;
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AdminPanel.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the key vaule of the record being deleted
            StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data
            Session["StaffNo"] = StaffNo;
            //redirect to delete page
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select an option from the box";
        }
    }

    protected void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}