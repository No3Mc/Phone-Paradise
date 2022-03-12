using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;

public partial class Stock_StockAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }
    }


    //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode
    void DisplayStocks()
    {

    }











    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockMain.aspx");
    }






















    //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode


    //function for adding new record


    //void Add()
    //{
    //    //create an instance of the book list
    //    PSSClasses.clsStockCollection StockBook = new PSSClasses.clsStockCollection();
    //    //validate the data on the web form
    //    String Error = StockList.ThisStock.Valid(txtStockName.Text, txtWarehouseNo.Text, txtLocation.Text, txtQuantity.Text, txtBarcode.Text);
    //    //if the data is OK then add it to the objcet
    //    if (Error == "")
    //    {
    //        //get the data entered by the user
    //        StockList.ThisStock.StockName = txtStockName.Text;
    //        StockList.ThisStock.WarehouseNo = txtWarehouseNo.Text;
    //        StockList.ThisStock.Location = txtLocation.Text;
    //        StockList.ThisStock.Quantity = txtQuantity.Text;
    //        StockList.ThisStock.Barcode = txtBarcode.Text;
    //        //add the record
    //        StockList.Add();
    //        //all done so redirect back to the main page
    //        Response.Redirect("StockMain.aspx");
    //    }
    //    else
    //    {
    //        //report an error
    //        lblError.Text = "problems with entries" + Error;
    //    }
    //}


}