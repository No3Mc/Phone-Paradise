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

    }

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
            txWarehouseno.Text = AStock.WarehouseNo;
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
        AStock.StockName = txtStockname.Text;
        Session["AStock"] = AStock;
        //redirect to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}