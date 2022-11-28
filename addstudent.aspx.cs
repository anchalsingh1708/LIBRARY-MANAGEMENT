using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace anchalproject
{
    public partial class addstudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {

            if (Txtname.Text != "" && txtno.Text != "" && txtdep.Text != "" && txtsem.Text != "" &&  txtcon.Text!="" &&  txtemail.Text!="")
            {


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into NewStudent values(@sname,@senroll,@sdep,@ssem,@scon,@semail)", con);
                cmd.Parameters.AddWithValue("@sname", Txtname.Text);
                cmd.Parameters.AddWithValue("@senroll", txtno.Text);
                cmd.Parameters.AddWithValue("@sdep", txtdep.Text);
                cmd.Parameters.AddWithValue("@ssem", txtsem.Text);
                cmd.Parameters.AddWithValue("@scon", txtcon.Text);
                cmd.Parameters.AddWithValue("@semail", txtemail.Text);


                cmd.ExecuteNonQuery();
                Response.Write("succcesfully added data");
                con.Close();
            }
            else
            {
                Response.Write("Empty field not allowwd!!");
            }
        }

        protected void btnexit_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}