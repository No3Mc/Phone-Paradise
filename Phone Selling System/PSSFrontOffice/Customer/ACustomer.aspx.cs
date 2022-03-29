using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;
//Done by Memon
public partial class ACustomer : System.Web.UI.Page
{
    Int32 CustID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustID = Convert.ToInt32(Session["CustID"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCusts();
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer id
        ACustomer.Name = txtName.Text;
        //store the name in the session object
        Session["ACustomer"] = ACustomer;
        //redirect to the Main customer page
        Response.Redirect("Custpg.aspx");

    }
    void DisplayCusts()
    {
        //create an instance of the Customer collection
        PSSClasses.clsCustomerCollection Custs = new PSSClasses.clsCustomerCollection();
        //find the record to update
        Custs.ThisCust.Find(CustID);
        //display the data for this record
        txtAddress.Text = Custs.ThisCust.Address;
        txtDOB.Text = Custs.ThisCust.DOB;
        txtName.Text = Custs.ThisCust.Name;
        txtEmail.Text = Custs.ThisCust.Email;
        txtPhoneNo.Text = Custs.ThisCust.PhoneNo;
    }
    void Add()
    {
        //create an instance of the holidays
        PSSClasses.clsCustomerCollection Custs = new PSSClasses.clsCustomerCollection();

        //validate the data on the web form
        String Error = Custs.ThisCust.Valid(Convert.ToInt32(txtCustID.Text), txtAddress.Text, txtDOB.Text, txtName.Text, txtEmail.Text, txtPhoneNo.Text);
        //if the data is Ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            Custs.ThisCust.CustID = Convert.ToInt32(txtCustID.Text);
            Custs.ThisCust.Address = txtAddress.Text;
            Custs.ThisCust.DOB = txtDOB.Text;
            Custs.ThisCust.Name = txtName.Text;
            Custs.ThisCust.Email = txtEmail.Text;
            Custs.ThisCust.PhoneNo = txtPhoneNo.Text;
            //add the record
            Custs.Add();
            //all done so redirect back to the custmain page
            Response.Redirect("CustMain.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the entries " + Error;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Custpg.aspx");
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Cust class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustID;
        //variable to store the result of the find operation
        bool found = false;
        //get the primary key entered by the user
        CustID = Convert.ToInt32(txtCustID.Text);
        //find the record
        found = ACustomer.Find(CustID);
        //if found
        if (found == true)
        {
            //display the values of the properties in the form
            txtAddress.Text = ACustomer.Address;
            txtDOB.Text = ACustomer.DOB;
            txtName.Text = ACustomer.Name;
            txtEmail.Text = ACustomer.Email;
            txtPhoneNo.Text = ACustomer.PhoneNo;
            //error label
            lblError.Text = " found";
        }
        else
        {
            //display the error msg
            lblError.Text = "Not found";
        }

    }
    void Update()
    {
        //create an instance of the Customer from collection
        PSSClasses.clsCustomerCollection Customers = new PSSClasses.clsCustomerCollection();

        //validate the data on the web form
        String Error = Customers.ThisCust.Valid(Convert.ToInt32(txtCustID.Text), txtAddress.Text, txtDOB.Text, txtName.Text, txtEmail.Text, txtPhoneNo.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {


            //find the record to update
            Customers.ThisCust.Find(CustID);
            //get the data entered by the user

            Customers.ThisCust.CustID = Convert.ToInt32(txtCustID.Text);
            Customers.ThisCust.Address = txtAddress.Text;
            Customers.ThisCust.DOB = txtDOB.Text;
            Customers.ThisCust.Name = txtName.Text;
            Customers.ThisCust.Email = (txtEmail.Text);
            Customers.ThisCust.PhoneNo = (txtPhoneNo.Text);
            //update the record
            Customers.Update();
            //all done so redirect back to main customer page
            Response.Redirect("Custpg.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the entries" + Error;
        }
    }

}
