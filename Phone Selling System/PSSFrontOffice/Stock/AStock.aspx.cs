using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;
//Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
//Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store

public partial class _Default : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StockID;

    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
            DisplaylstStocks();
        }



    }


    void DisplaylstStocks()
    {
        //create an instance of the Stock collection
        PSSClasses.clsStockCollection StockBook = new PSSClasses.clsStockCollection();
        //set the data source to the list of warehouse in the collection
        lstStocks.DataSource = StockBook.StockList;
        //set the name of the primary key
        lstStocks.DataValueField = "StockID";
        //set the data field to display
        lstStocks.DataTextField = "StockID";
        //bind the data to the list
        lstStocks.DataBind();
    }


    void DisplayStocks()
    {
        //create an instance of the county collection
        PSSClasses.clsStockCollection Stocks = new PSSClasses.clsStockCollection();
        //find the record to update
        Stocks.ThisStock.Find(StockID);
        //display the data for this record
        txtStockname.Text = Stocks.ThisStock.StockName;
        txtLocation.Text = Stocks.ThisStock.Location;
        txtQuantity.Text = Stocks.ThisStock.Quantity;
        txtBarcode.Text = Stocks.ThisStock.Barcode;
        txtWarehouseNo.Text = Stocks.ThisStock.WarehouseNo;

    }







    protected void btnOK_Click1(object sender, EventArgs e)
    {
        ////create a new instance of clsStock
        //clsStock AStock = new clsStock();
        ////capute the stock name
        //string WarehouseNo = txtWarehouseNo.Text;
        //string StockName = txtStockname.Text;
        //string Location = txtLocation.Text;
        //string Quantity = txtQuantity.Text;
        //string Barcode = txtBarcode.Text;

        //String Error = "";
        //Error = AStock.Valid(StockName, WarehouseNo, Location, Quantity, Barcode);
        //if (Error == "")
        //{
        //    //capture the warehouse no
        //    AStock.WarehouseNo = WarehouseNo;
        //    AStock.StockName= StockName;
        //    AStock.Location= Location;
        //    AStock.Quantity= Quantity;
        //    AStock.Barcode= Barcode;

        //    Session["AStock"] = AStock;
        //    //redirect to the viewer page
        //    Response.Redirect("StockViewer.aspx");
        //}
        //else
        //{
        //    //display the error msg
        //    lblError.Text = Error;
        //}

        if (StockID == -1)
        {
            //add the new record
            Add();
            //all done so redirect back to main page
            Response.Redirect("StockMain.aspx");
        }
        else
        {
            //update the record
            Update();
        }

    }
    //function for adding new records
    void Add()
    {
        //create an instance of the holidays
        PSSClasses.clsStockCollection Stocks = new PSSClasses.clsStockCollection();

        //validate the data on the web form
        String Error = Stocks.ThisStock.Valid(txtStockname.Text, txtWarehouseNo.Text, txtLocation.Text, txtQuantity.Text, txtBarcode.Text);
        //if the data is Ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            Stocks.ThisStock.StockName = txtStockname.Text;
            Stocks.ThisStock.WarehouseNo = txtWarehouseNo.Text;
            Stocks.ThisStock.Location = txtLocation.Text;
            Stocks.ThisStock.Quantity = txtQuantity.Text;
            Stocks.ThisStock.Barcode = txtBarcode.Text;
            //add the record
            Stocks.Add();
            //all done so redirect back to the main page
            Response.Redirect("StockMain.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems " + Error;
        }
    }




    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AStock = new clsStock();
        //variable to store the primary key
        Int32 StockID;
        //variable to store the result of the find operation
        bool found = false;
        //get the primary key entered by the user
        StockID = Convert.ToInt32(txtStockID.Text);
        //find the record
        found = AStock.Find(StockID);
        //if found
        if (found == true)
        {
            //display the values of the properties in the form
            txtStockname.Text = AStock.StockName;
            txtWarehouseNo.Text = AStock.WarehouseNo;
            txtLocation.Text = AStock.Location;
            txtQuantity.Text = AStock.Quantity;
            txtBarcode.Text = AStock.Barcode;

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
        Response.Redirect("StockMain.aspx");
    }

    void Update()
    {
        //create an instance of the holiday book
        PSSClasses.clsStockCollection Stocks = new PSSClasses.clsStockCollection();

        //validate the data on the web form
        String Error = Stocks.ThisStock.Valid(txtStockname.Text, txtWarehouseNo.Text, txtLocation.Text, txtQuantity.Text, txtBarcode.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            Stocks.ThisStock.Find(StockID);
            //get the data entered by the user
            Stocks.ThisStock.StockName = txtStockname.Text;
            Stocks.ThisStock.WarehouseNo = txtWarehouseNo.Text;
            Stocks.ThisStock.Location = txtLocation.Text;
            Stocks.ThisStock.Quantity = (txtQuantity.Text);
            Stocks.ThisStock.Barcode = (txtBarcode.Text);
            //update the record
            Stocks.Update();
            //all done so redirect back to main page
            Response.Redirect("StockMain.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems" + Error;
        }
    }

















    protected void lstStocks_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}