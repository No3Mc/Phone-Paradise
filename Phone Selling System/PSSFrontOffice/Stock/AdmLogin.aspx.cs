using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


//Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
//Datasource hidden for security and login reason

public partial class Stock_AdmLogin : System.Web.UI.Page
{
    private object password;

    private object User;

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    //login click
    protected void Button1_Click(object sender, EventArgs e)
{

        //SqlConnection conn = new SqlConnection(@"Hidden for safety reason");
        //conn.Open();
        //string checkuser = "select count(*) from tblAdmin where User = '" + User + "'";
        //SqlCommand com = new SqlCommand(checkuser, conn);
        //int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        //conn.Close();
        //if (temp == 1)
        //{
        //    conn.Open();
        //    string checkpasswordQuery = "select Password from tblAdmin where User = '" + User + "'";
        //SqlCommand passcom = new SqlCommand(checkpasswordQuery, conn);
        //    string password= passcom.ExecuteScalar().ToString();

        //    if (password == password)
        //    {
        //        Session["New"] = User;
        //        Response.Redirect("Home.aspx");
        //        Response.Write("Correct pass");
        //    }
        //    else
        //    {
        //        Response.Write("Pass is incorrect");
        //    }
        //}
        //else
        //{
        //    Response.Write("user is incorrect");
        //}

        Response.Redirect("StockMain.aspx");


    }
}




