using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;

public partial class Staff_AStaff : System.Web.UI.Page
{
    // Variable to store the primary key with page level scope
    Int32 StaffNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNo = Convert.ToInt32(Session["StaffNo"]);

        if (!IsPostBack)
        {
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        // Create an instance of the Staff collection
        clsStaffCollection AStaff = new clsStaffCollection();

        // Set the data source to find the staff
        lstStaff.DataSource = AStaff.StaffList;

        // Set the name of the primary key
        lstStaff.DataValueField = "StaffNo";

        // Set the data field to display
        lstStaff.DataTextField = "StaffName";

        // Bind the data to the list
        lstStaff.DataBind();
    }

    // Function for adding new records
    void Add()
    {
        clsStaffCollection Staff = new clsStaffCollection();

        // Validate the data on the web form
        string Error = Staff.ThisStaff.Valid(txtSEmail.Text, txtSName.Text, txtSPassword.Text, txtSPos.Text, txtSPhone.Text);

        // If the data is OK, then add it to the object
        if (Error == "")
        {
            // Find the record to update
            Staff.ThisStaff.Find(StaffNo);

            // Get the data entered by the user
            Staff.ThisStaff.StaffEmail = txtSEmail.Text;
            Staff.ThisStaff.StaffName = txtSName.Text;
            Staff.ThisStaff.StaffPassword = txtSPassword.Text;
            Staff.ThisStaff.StaffPosition = txtSPos.Text;
            Staff.ThisStaff.StaffTelephoneNo = txtSPhone.Text;

            // Add the record
            Staff.Add();

            // All done, so redirect back to the main page
            Response.Redirect("AStaff.aspx");
        }
        else
        {
            // Report an error
            lblError.Text = "There were problems: " + Error;
        }
    }

    void Update()
    {
        clsStaffCollection Staff = new clsStaffCollection();

        // Validate the data on the web form
        string Error = Staff.ThisStaff.Valid(txtSEmail.Text, txtSName.Text, txtSPassword.Text, txtSPos.Text, txtSPhone.Text);

        // If the data is OK, then update the record
        if (Error == "")
        {
            // Find the record to update
            Staff.ThisStaff.Find(StaffNo);

            // Get the data entered by the user
            Staff.ThisStaff.StaffEmail = txtSEmail.Text;
            Staff.ThisStaff.StaffName = txtSName.Text;
            Staff.ThisStaff.StaffPassword = txtSPassword.Text;
            Staff.ThisStaff.StaffPosition = txtSPos.Text;
            Staff.ThisStaff.StaffTelephoneNo = txtSPhone.Text;

            // Update the record
            Staff.Update();

            // All done, so redirect back to main page
            Response.Redirect("AStaff.aspx");
        }
        else
        {
            // Report an error
            lblError.Text = "There were problems: " + Error;
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Add the new record
        Add();
        // All done, so redirect back to the main page
        //Response.Redirect("AddStaff.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the Staff class
        clsStaff AStaff = new clsStaff();

        // Variable to store the primary key
        Int32 StaffNo;

        // Variable to store the result of the find operation
        bool found = false;

        // Get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffNo.Text);

        // Find the record
        found = AStaff.Find(StaffNo);

        // If found
        if (found)
        {
            // Display the values of the properties in the form
            txtSEmail.Text = AStaff.StaffEmail;
            txtSName.Text = AStaff.StaffName;
            txtSPassword.Text = AStaff.StaffPassword;
            txtSPos.Text = AStaff.StaffPosition;
            txtSPhone.Text = AStaff.StaffTelephoneNo;

            lblError.Text = "Found";
        }
        else
        {
            // Display the error message
            lblError.Text = "Not found";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AdminPanel.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // If a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            // Get the key value of the record being deleted
            StaffNo = Convert.ToInt32(lstStaff.SelectedValue);

            // Store the data
            Session["StaffNo"] = StaffNo;

            // Redirect to delete page
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select an option from the box";
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Handle the button click event
    }

    protected void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
