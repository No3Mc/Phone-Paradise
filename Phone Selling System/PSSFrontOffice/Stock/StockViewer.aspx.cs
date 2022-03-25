using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;
//Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
//Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }

    }
    //It displays the WarehouseNo in the stock list
    void DisplayStocks()
    {
        //create an instance of the county collection
        PSSClasses.clsStockCollection Stocks = new PSSClasses.clsStockCollection();
        //set the data source to the list of warehouse in the collection
        lstStocks.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStocks.DataValueField = "StockID";
        //set the data field to display
        lstStocks.DataTextField = "WarehouseNo";
        //bind the data to the list
        lstStocks.DataBind();
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        //it redirects to admlogin page
        Response.Redirect("AdmLogin.aspx");

    }



    protected void btnBack_Click(object sender, EventArgs e)
    {
        //it redirects to admpanel
        Response.Redirect("/AdminPanel.aspx");
    }
}