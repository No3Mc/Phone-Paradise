using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;

public partial class _Default : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        ////if this is the first time the page is displayed
        //if (IsPostBack == false)
        //{
        //    //update the list box
        //    DisplayStocks();
        //}



    }

    //void DisplayStocks()
    //{
    //    //create an instance of the county collection
    //    PSSClasses.clsStockCollection Stocks = new PSSClasses.clsStockCollection();
    //    //set the data source to the list of warehouse in the collection
    //    lstStocks.DataSource = Stocks.StockList;
    //    //set the name of the primary key
    //    lstStocks.DataValueField = "stockid";
    //    //set the data field to display
    //    lstStocks.DataTextField = "warehouseno";
    //    //bind the data to the list
    //    lstStocks.DataBind();
    //}





    protected void btnFind_Click1(object sender, EventArgs e)
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
            txtBarcode.Text = AStock.Quantity;
        }
    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capute the stock name
        string WarehouseNo = txtWarehouseNo.Text;
        string StockName = txtStockname.Text;
        string Location = txtLocation.Text;
        string Quantity = txtQuantity.Text;
        string Barcode = txtBarcode.Text;


        String Error = "";
        Error = AStock.Valid(WarehouseNo, StockName, Location, Quantity, Barcode);
        if (Error == "")
        {
            //capture the house no
            AStock.WarehouseNo = WarehouseNo;
            AStock.StockName= StockName;
            AStock.Location= Location;
            AStock.Quantity= Quantity;
            AStock.Barcode= Barcode;

            Session["AStock"] = AStock;
            //redirect to the viewer page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display the error msg
            lblError.Text = Error;
        }
    }

    //void Add()
    //{
    //    //get the data entered by the user
    //    StockBook.ThisStock.Warehouse = txtWarehouseNo.Text;
    //    StockBook.ThisStock.StockName = txtStockname.Text;
    //    StockBook.ThisStock.Location = txtLocation.Text;
    //    StockBook.ThisStock.Quantity = txtQuantity.Text;
    //    StockBook.ThisStock.Barcode = txtBarcode.Text;

    //}


}