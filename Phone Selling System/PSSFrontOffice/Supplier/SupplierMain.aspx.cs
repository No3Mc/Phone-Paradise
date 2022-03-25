using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;

public partial class Supplier_SupplierMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is dosplayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplaySuppliers();
        }

    }
    private void DisplaySuppliers()
    {
        //create an instance of the customer collection
        clsSupplierCollection aThisSupplier = new clsSupplierCollection();
        //set the data source to the list of customers in the collection
        ListBox1.DataSource = aThisSupplier.SupplierList;
        //set the name of the primary key
        ListBox1.DataValueField = "SupplierID";
        //set the data field to display
        ListBox1.DataTextField = "Name";
        //bind the data to the list
        ListBox1.DataBind();
    }





   





    protected void SFind_Click(object sender, EventArgs e)
    {
        Response.Redirect("FindSupplier.aspx");
    }

    protected void AdminPanel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminPanel.aspx");
    }

    


    

    

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add Supplier.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add Supplier.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add Supplier.aspx");
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdminPanel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminPanel.aspx");
    }
}