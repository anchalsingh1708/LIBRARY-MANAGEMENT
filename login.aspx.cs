using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;
using System.Windows.Forms;

namespace anchalproject
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString);
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=con;
            cmd.CommandText = "select *from logintable where username='" + TextBox1.Text + "'and pass='" + TextBox2.Text+ "'";
                     SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count !=0)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                Response.Write("wrong username or password");
                }
            //con.Close();

           
            
        }

        
    }
}