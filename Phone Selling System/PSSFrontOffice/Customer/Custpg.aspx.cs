using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;
//Done by Memon
public partial class Customer_Custpg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the Stock collection
        PSSClasses.clsCustomerCollection CustBook = new PSSClasses.clsCustomerCollection();
        //set the data source to the list of CustBook in the collection
        lstCust.DataSource = CustBook.CustList;
        //set the name of the primary key
        lstCust.DataValueField = "CustID";
        //set the data field to display
        lstCust.DataTextField = "Name";
        //bind the data to the list
        lstCust.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustAdd.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be deleted
        Int32 CustID;
        //if a record has been selected from the list
        if (lstCust.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustID = Convert.ToInt32(lstCust.SelectedValue);
            //Store the data in the session object
            Session["Cust"] = CustID;
            //redirects to the delete page
            Response.Redirect("ACustomer.aspx");
        }
        else //if no record has been selected
        {
            //display an error#
            lblError.Text = "Please select a record to edit from the list";
        }


    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustID;
        //if a record has been selected from the list

        if (lstCust.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustID = Convert.ToInt32(lstCust.SelectedValue);
            //Store the data in the session object
            Session["CustID"] = CustID;
            //redirects to the Customer's delete page
            Response.Redirect("CustDel.aspx");
        }

        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }

    }

        Int32 DisplayCusts(string LocationFilter)
        {
            ///this function accepts one parameter - the post code to filter the list on
            ///it populates the list box with data from the middle layer class
            ///it returns a single value, the number of records found

            //create a new instance of the clsCustoemrCollection/CustList
            clsCustomerCollection CustList = new clsCustomerCollection();
            //var to store the count of records
            Int32 RecordCount;

            //var to store the CustID
            string CustID;
            //var to store the Address
            string Address;
            //var to store the DOB
            string DOB;
            //var to store the Name value
            string Name;
            //var to store the Email
            string Email;
            //var to store the PhoneNo
            string PhoneNo;

            //var to store the index
            // string CustID;
            Int32 Index = 0;
            //clear the list of any existing items
            lstCust.Items.Clear();

        //call the filter by LocationFilter method
        CustList.ReportByLocation(LocationFilter);
            //get the count of records found
            RecordCount = CustList.Count;
            //loop through each record found using the index to point to each record in the data table
            while (Index < RecordCount)
            {
             CustID = Convert.ToString(CustList.CustList[Index].CustID);
            //get the Address from the query results
            Address = Convert.ToString(CustList.CustList[Index].Address);
            DOB = Convert.ToString(CustList.CustList[Index].DOB);
            Name = Convert.ToString(CustList.CustList[Index].Name);
            Email = Convert.ToString(CustList.CustList[Index].Email);
            PhoneNo = Convert.ToString(CustList.CustList[Index].PhoneNo);

            //set up a new object of class list item 
            ListItem NewItem = new ListItem(CustID + " : CustID" + " | " + "Address: " + Address + " |" + " DOB: " + DOB + " |" + " Name: " + Name +  " |" + " Email: " + Email + " |" + " PhoneNo: " + PhoneNo);
            //add the new item to the list
             lstCust.Items.Add(NewItem);
                //increment the index
                Index++;
            }
            //return the number of records found
            return RecordCount;
        }
    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayCusts function to the record count var
        RecordCount = DisplayCusts(txtWarehouseNo.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }


}