using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace anchalproject
{
    public partial class addbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbname.Text != "" && txtbauthor.Text != "" && txtbprice.Text != "" && txtbquan.Text != "")
            {


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into NewBook1 values(@bn,@ba,@bp,@bq)", con);
                cmd.Parameters.AddWithValue("@bn", txtbname.Text);
                cmd.Parameters.AddWithValue("@ba", txtbauthor.Text);
                cmd.Parameters.AddWithValue("@bp", txtbprice.Text);
                cmd.Parameters.AddWithValue("@bq", txtbquan.Text);

                cmd.ExecuteNonQuery();
                Response.Write("succcesfully added data");
                con.Close();
            }
            else
            {
                Response.Write("Empty field not allowed!!");
            }

        }


        protected void btncancel_Click(object sender, EventArgs e)
        {

            Response.Redirect("home.aspx");

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from NewBook1 where bname =@name", con);
                cmd.Parameters.AddWithValue("@name",txtbname.Text);
                cmd.ExecuteNonQuery();
                Response.Write("deleted successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("update NewBook1 set bquan=@bquan where bname=@bname", con);
                cmd.Parameters.AddWithValue("@bquan", txtbquan.Text);
                cmd.Parameters.AddWithValue("@bname", txtbname.Text);

                Response.Write("updated successfully");
                con.Close();

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}