using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplicationForm
{
    public partial class Employees : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=CHETUIWK884\\SQLEXPRESS;Initial Catalog=abc;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Employees(name,age,mobile)values('" + txtname + "','" + txtage + "','" + txtmobile + "',con");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btnselect_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select*from Employees",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            grd.DataSource = dt;
            grd.DataBind();
        }
    }
}