using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;
//Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
//Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store

public partial class Stock_StockAdd : System.Web.UI.Page
{

    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the book to be proccessed
        StockID = Convert.ToInt32(Session["StockID"]);
        if (IsPostBack == false)
        {
            //populate the list of book
            DisplayStocks();

        }
    }


    //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode
    void DisplayStocks()
    {
        //get the number of the book to be proccessed
        StockID = Convert.ToInt32(Session["BookId"]);
        if (IsPostBack == false)    
        {
            //populate the list of book
            DisplayStocks();

        }        //craete an instance of the book list
        clsStockCollection StocksList = new clsStockCollection();
        //find the record to update
        StocksList.ThisStock.Find(StockID);
        //display the data for this record
        txtStockName.Text = StocksList.ThisStock.StockName;
        txtWarehouseNo.Text = StocksList.ThisStock.WarehouseNo;
        txtLocation.Text = StocksList.ThisStock.Location;
        txtQuantity.Text= StocksList.ThisStock.Quantity;
        txtBarcode.Text = StocksList.ThisStock.Barcode;
    }
    //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode











    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockMain.aspx");
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (StockID == -1)
        {
            //add 
            Add();
        }
        else
        {
            //Update
            Update();
        }

        //Response.Redirect("StockMain.aspx");
    }




    //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode

    //function for updating new record
    void Update()
    {
        //create an instance of the book list
        clsStockCollection StocksList = new clsStockCollection();
        //validate the data on the web form
        String Error = StocksList.ThisStock.Valid(txtStockName.Text, txtWarehouseNo.Text, txtLocation.Text, txtQuantity.Text, txtBarcode.Text);
        //if the data is OK then add it to the objcet
        if (Error == "")
        {
            //find the record to update
            StocksList.ThisStock.Find(StockID);
            //get the data entered by the user
            //get the data entered by the user
            StocksList.ThisStock.StockName = txtStockName.Text;
            StocksList.ThisStock.WarehouseNo = txtWarehouseNo.Text;
            StocksList.ThisStock.Location = txtLocation.Text;
            StocksList.ThisStock.Quantity = txtQuantity.Text;
            StocksList.ThisStock.Barcode = txtBarcode.Text;
            //add the record
            StocksList.Update();
            //all done so redirect back to the main page
            Response.Redirect("StockMain.aspx");
        }
        else
        {
            //report an erro
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode


    //function for adding new record


    void Add()
    {
        //create an instance of the book list
        PSSClasses.clsStockCollection StocksList = new PSSClasses.clsStockCollection();
        //validate the data on the web form
        String Error = StocksList.ThisStock.Valid(txtStockName.Text, txtWarehouseNo.Text, txtLocation.Text, txtQuantity.Text, txtBarcode.Text);
        //if the data is OK then add it to the objcet
        if (Error == "")
        {
            //get the data entered by the user
            StocksList.ThisStock.StockName = txtStockName.Text;
            StocksList.ThisStock.WarehouseNo = txtWarehouseNo.Text;
            StocksList.ThisStock.Location = txtLocation.Text;
            StocksList.ThisStock.Quantity = txtQuantity.Text;
            StocksList.ThisStock.Barcode = txtBarcode.Text;
            //add the record
            StocksList.Add();
            //all done so redirect back to the main page
            Response.Redirect("StockMain.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "problems with entries" + Error;
        }
    }






}