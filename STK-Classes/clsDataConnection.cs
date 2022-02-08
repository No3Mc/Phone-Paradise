using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STK_Classes
{
    internal class clsDataConnection
    {
        //connection obj used to connect to the database
        SqlConnection connectionToDB = new SqlConnection();
        //data adapter use to transfer data to and from the DB
        SqlDataAdapter dataChannel = new SqlDataAdapter();
    }
    set
    {
        //set the query results
        dataTable = value;
    }
}
