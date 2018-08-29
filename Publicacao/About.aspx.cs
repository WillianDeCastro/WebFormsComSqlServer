using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }




    protected void btnInfo_Click(object sender, EventArgs e)
    {
        string conecString = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;


        SqlConnection cn = new SqlConnection(conecString);

        cn.Open();

        DataTable dt = new DataTable();
        dt.Load(new SqlCommand("Select Nome from Pessoas", cn).ExecuteReader());

        cn.Close();
    }
}