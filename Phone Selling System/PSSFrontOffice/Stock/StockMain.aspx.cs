using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;
//Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
//Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store

public partial class Stock_StockMain : System.Web.UI.Page
{
    //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStockName();
            DisplayWarehouseNo();
            DisplayLocation();
            DisplayQuantity();
            DisplayBarcode();
        }

    }

    void DisplayBarcode()
    {
        //create an instance of the Stock collection
        PSSClasses.clsStockCollection StockBook = new PSSClasses.clsStockCollection();
        //set the data source to the list of warehouse in the collection
        lstBarcode.DataSource = StockBook.StockList;
        //set the name of the primary key
        lstBarcode.DataValueField = "StockID";
        //set the data field to display
        lstBarcode.DataTextField = "Barcode";
        //bind the data to the list
        lstBarcode.DataBind();
    }

    void DisplayQuantity()
    {
        //create an instance of the Stock collection
        PSSClasses.clsStockCollection StockBook = new PSSClasses.clsStockCollection();
        //set the data source to the list of warehouse in the collection
        lstQuantity.DataSource = StockBook.StockList;
        //set the name of the primary key
        lstQuantity.DataValueField = "StockID";
        //set the data field to display
        lstQuantity.DataTextField = "Quantity";
        //bind the data to the list
        lstQuantity.DataBind();
    }

    void DisplayStockName()
    {
        //create an instance of the Stock collection
        PSSClasses.clsStockCollection StockBook = new PSSClasses.clsStockCollection();
        //set the data source to the list of warehouse in the collection
        lstStockName.DataSource = StockBook.StockList;
        //set the name of the primary key
        lstStockName.DataValueField = "StockID";
        //set the data field to display
        lstStockName.DataTextField = "StockName";
        //bind the data to the list
        lstStockName.DataBind();
    }


    void DisplayLocation()
    {
        //create an instance of the Stock collection
        PSSClasses.clsStockCollection StockBook = new PSSClasses.clsStockCollection();
        //set the data source to the list of warehouse in the collection
        lstLocation.DataSource = StockBook.StockList;
        //set the name of the primary key
        lstLocation.DataValueField = "StockID";
        //set the data field to display
        lstLocation.DataTextField = "Location";
        //bind the data to the list
        lstLocation.DataBind();
    }



    void DisplayWarehouseNo()
        {
            //create an instance of the Stock collection
            PSSClasses.clsStockCollection StockBook = new PSSClasses.clsStockCollection();
        //set the data source to the list of warehouse in the collection
        lstWarehouseNo.DataSource = StockBook.StockList;
        //set the name of the primary key
        lstWarehouseNo.DataValueField = "StockID";
        //set the data field to display
        lstWarehouseNo.DataTextField = "WarehouseNo";
        //bind the data to the list
        lstWarehouseNo.DataBind();

        }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockAdd.aspx");
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StockID;
        //if a record has been selected from the list
        //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode
        //StockName
        if (lstStockName.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockID = Convert.ToInt32(lstStockName.SelectedValue);
            //Store the data in the session object
            Session["StockID"] = StockID;
            //redirects to the delete page
            Response.Redirect("AStock.aspx");
        }
        //WarehouseNo

        if (lstWarehouseNo.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockID = Convert.ToInt32(lstWarehouseNo.SelectedValue);
            //Store the data in the session object
            Session["StockID"] = StockID;
            //redirects to the delete page
            Response.Redirect("AStock.aspx");
        }
        //Location
        if (lstLocation.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockID = Convert.ToInt32(lstLocation.SelectedValue);
            //Store the data in the session object
            Session["StockID"] = StockID;
            //redirects to the delete page
            Response.Redirect("AStock.aspx");
        }

        //Quantity
        if (lstBarcode.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockID = Convert.ToInt32(lstBarcode.SelectedValue);
            //Store the data in the session object
            Session["StockID"] = StockID;
            //redirects to the delete page
            Response.Redirect("AStock.aspx");
        }
        //Barcode
        if (lstQuantity.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockID = Convert.ToInt32(lstWarehouseNo.SelectedValue);
            //Store the data in the session object
            Session["StockID"] = StockID;
            //redirects to the delete page
            Response.Redirect("AStock.aspx");
        }













        else //if no record has been selected
        {
            //display an error#
            lblError.Visible = true;
            lblError.Text = "Please select a record to edit from teh list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StockID;
        //if a record has been selected from the list
        //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode




        if (lstStockName.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockID = Convert.ToInt32(lstStockName.SelectedValue);
            //Store the data in the session object
            Session["StockID"] = StockID;
            //redirects to the delete page
            Response.Redirect("StockDel.aspx");
        }

        if (lstWarehouseNo.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockID = Convert.ToInt32(lstWarehouseNo.SelectedValue);
            //Store the data in the session object
            Session["StockID"] = StockID;
            //redirects to the delete page
            Response.Redirect("StockDel.aspx");
        }

        if (lstLocation.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockID = Convert.ToInt32(lstLocation.SelectedValue);
            //Store the data in the session object
            Session["StockID"] = StockID;
            //redirects to the delete page
            Response.Redirect("StockDel.aspx");
        }

        if (lstQuantity.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockID = Convert.ToInt32(lstQuantity.SelectedValue);
            //Store the data in the session object
            Session["StockID"] = StockID;
            //redirects to the delete page
            Response.Redirect("StockDel.aspx");
        }


        
        if (lstBarcode.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockID = Convert.ToInt32(lstBarcode.SelectedValue);
            //Store the data in the session object
            Session["StockID"] = StockID;
            //redirects to the delete page
            Response.Redirect("StockDel.aspx");
        }
















        else //if no record has been selected
        {
            //display an error#
            lblError.Visible = true;
            lblError.Text = "Please select a record to delete from the lists";
        }
    }




    //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode

    Int32 DisplayStocks(string LocationFilter)
    {
        ///this function accepts one parameter - the post code to filter the list on
        ///it populates the list box with data from the middle layer class
        ///it returns a single value, the number of records found

        //create a new instance of the clsAddress
        clsStockCollection StockList = new clsStockCollection();
        //var to store the count of records
        Int32 RecordCount;

        //var to store the house no
        string StockID;
        string StockName;
        //var to store the street name
        string WarehouseNo;
        //var to store the primary key value
        string Location;
        string Quantity;
        string Barcode;

        //var to store the index
        // string StockID;
        Int32 Index = 0;
        //clear the list of any existing items
        lstStockName.Items.Clear();
        lstWarehouseNo.Items.Clear();
        lstLocation.Items.Clear();
        lstQuantity.Items.Clear();
        lstBarcode.Items.Clear();

        //call the filter by LocationFilter method
        StockList.ReportByLocation(LocationFilter);
        //get the count of records found
        RecordCount = StockList.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            StockID = Convert.ToString(StockList.StockList[Index].StockID);
            //get the house no from the query results
            StockName = Convert.ToString(StockList.StockList[Index].StockName);
            //get the street from the query results
            WarehouseNo = Convert.ToString(StockList.StockList[Index].WarehouseNo);
            Location = Convert.ToString(StockList.StockList[Index].Location);
            Quantity = Convert.ToString(StockList.StockList[Index].Quantity);
            Barcode = Convert.ToString(StockList.StockList[Index].Barcode);


            //set up a new object of class list item 

            ListItem NewItem = new ListItem(StockID + " : StockID" + " | " + "WarehouseNo: " + WarehouseNo + " |" + " StockName: " + StockName + " |" + " Location: " + Location + " |" + " Quantity: " + Quantity + " |" + " Barcode: " + Barcode);

            //add the new item to the list

            lstStockName.Items.Add(NewItem);






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
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayStocks(txtWarehouseNo.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }









    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}