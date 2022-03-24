using PSSClasses.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Phone_PhoneMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first appearance of the form
        if (IsPostBack == false)
        {
            //displays phones in the list
            DisplayPhones("");
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PhoneID"] = -1;

        Response.Redirect("PhoneAdd.aspx?PhoneID=-1");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 PhoneID;

        if (lstPhone.SelectedIndex != -1)
        {
            PhoneID = Convert.ToInt32(lstPhone.SelectedValue); //get the primary key of the item

            Response.Redirect("APhone.aspx"); // redirect to the add page
        }
        else //if not
        {
            lblError.Text = "You need to select an item"; //display an error message
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 PhoneID;

        if (lstPhone.SelectedIndex != -1)
        {
            PhoneID = Convert.ToInt32(lstPhone.SelectedValue); //get the primary key of the item

            Response.Redirect("Delete.aspx"); // redirect to the delete page
        }
        else //if not
        {
            lblError.Text = "You need to select an item"; //display an error message
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        DisplayPhones("");
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        DisplayPhones(txtPhoneName.Text);
    }

    Int32 DisplayPhones(string PhoneNameFilter)
    {
        //declare variables
        Int32 PhoneID;
        string PhoneName;
        string PhoneManufacturer;
        //create instance of collection class
        clsPhoneCollection PhoneList = new clsPhoneCollection();
        PhoneList.FilterByName(PhoneNameFilter);

        Int32 RecordCount;
        Int32 Index = 0;
        RecordCount = PhoneList.Count;
        lstPhone.Items.Clear();
        while (Index < RecordCount)
        {
            PhoneID = PhoneList.PhoneList[Index].PhoneID;
            PhoneName = PhoneList.PhoneList[Index].PhoneName;
            PhoneManufacturer = PhoneList.PhoneList[Index].PhoneManufacturer;

            ListItem NewEntry = new ListItem(PhoneID + " " + PhoneName, PhoneID.ToString());

            lstPhone.Items.Add(NewEntry);
            Index++;
        }

        return RecordCount;
    }

    protected void lstPhone_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
