using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;
public partial class Customer_CustAdd : System.Web.UI.Page
{
    Int32 CustID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the book to be proccessed
        CustID = Convert.ToInt32(Session["StockID"]);
        if (IsPostBack == false)
        {
            //populate the list of book
            DisplayCustomers();

        }
    }

    void DisplayCustomers()
    {
        //craete an instance of the book list
        clsCustomerCollection CustList = new clsCustomerCollection();
        //display the data for this record
        CustList.ThisCust.Find(CustID);
        //display the data for this record
        txtAddress.Text = CustList.ThisCust.Address;
        txtDOB.Text = CustList.ThisCust.DOB;
        txtName.Text = CustList.ThisCust.Name;
        txtEmail.Text = CustList.ThisCust.Email;
        txtPhoneNo.Text = CustList.ThisCust.PhoneNo;



    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Custpg.aspx");
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        if (CustID == -1)
        {
            //add 
            Add();
        }
        else
        {
            //Update
            Update();
        }
    }


    void Add()
    {
        //create an instance of the book list
        PSSClasses.clsCustomerCollection CustList = new PSSClasses.clsCustomerCollection();
        //validate the data on the web form
        String Error = CustList.ThisCust.Valid(txtDOB.Text, txtAddress.Text, txtName.Text, txtEmail.Text, txtPhoneNo.Text);
        //if the data is OK then add it to the objcet
        if (Error == "")
        {
            //get the data entered by the user
            CustList.ThisCust.Address = txtName.Text;
            CustList.ThisCust.DOB = txtDOB.Text;
            CustList.ThisCust.Name = txtName.Text;
            CustList.ThisCust.Email = txtEmail.Text;
            CustList.ThisCust.PhoneNo = txtPhoneNo.Text;
            //add the record
            CustList.Add();
            //all done so redirect back to the main page
            Response.Redirect("Custpg.aspx");
        }



        else
        {
            //report an error
            lblError.Text = "problems with entries" + Error;
        }

    }




    void Update()
    {
        //create an instance of the Cust list
        clsCustomerCollection CustList = new clsCustomerCollection();
        //validate the data on the web form
        String Error = CustList.ThisCust.Valid(txtDOB.Text, txtAddress.Text, txtName.Text, txtEmail.Text, txtPhoneNo.Text);
        //if the data is OK then add it to the objcet
        if (Error == "")
        {
            //find the record to update
            CustList.ThisCust.Find(CustID);
            //get the data entered by the user
            //get the data entered by the user
            CustList.ThisCust.DOB = txtDOB.Text;
            CustList.ThisCust.Address = txtAddress.Text;
            CustList.ThisCust.Name = txtName.Text;
            CustList.ThisCust.Email = txtEmail.Text;
            CustList.ThisCust.PhoneNo = txtPhoneNo.Text;
            //add the record
            CustList.Update();
            //all done so redirect back to the main page
            Response.Redirect("Custpg.aspx");


        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }




}

































