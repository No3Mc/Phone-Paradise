using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;
//Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
//Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store

public partial class Stock_StockDel : System.Web.UI.Page
{
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);
    }

    void DelStock()
    {
        //function to delete the selected record
        //create a new instance of teh stock book
            clsStockCollection StocksBook = new clsStockCollection();
        //fiind the record to delet
        StocksBook.ThisStock.Find(StockID);
        //del teh record
        StocksBook.Del();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //del the record
        DelStock();
        Response.Redirect("StockMain.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockMain.aspx");
    }
}