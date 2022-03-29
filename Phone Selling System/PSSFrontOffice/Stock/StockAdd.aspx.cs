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
        //get the number of the Stock to be proccessed
        StockID = Convert.ToInt32(Session["StockID"]);
        if (IsPostBack == false)
        {
            //populate the list of Stock
            DisplayStocks();

        }
    }

    void DisplayStocks()
    {
        //craete an instance of the stock list
        clsStockCollection StocksList = new clsStockCollection();
        //display the data for this record
        StocksList.ThisStock.Find(StockID);
        //display the data for this record
        txtStockName.Text = StocksList.ThisStock.StockName;
        txtWarehouseNo.Text = StocksList.ThisStock.WarehouseNo;
        txtLocation.Text = StocksList.ThisStock.Location;
        txtQuantity.Text= StocksList.ThisStock.Quantity;
        txtBarcode.Text = StocksList.ThisStock.Barcode;
    }

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

    //function for updating new record
    void Update()
    {
        //create an instance of the stock list
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
            //report an error
            lblError.Visible = true;
            lblError.Text = "System was unable to proceed with your request. Please check your entries       " + Error;
        }
    }

    //function for adding new record
    void Add()
    {
        //create an instance of the Stock list
        PSSClasses.clsStockCollection StocksList = new PSSClasses.clsStockCollection();
        //validate the data on the web form
        String Error = StocksList.ThisStock.Valid(txtStockName.Text, txtWarehouseNo.Text, txtLocation.Text, txtQuantity.Text, txtBarcode.Text);
        //if the data is OK then add it to the object
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
            lblError.Visible = true;
            lblError.Text = "System was unable to proceed with your request. Please check your entries       " + Error;
        }
    }

}