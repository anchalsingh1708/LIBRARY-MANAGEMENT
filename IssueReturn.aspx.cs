using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace anchalproject
{
    public partial class IssueReturn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand("select bname from  Newbook1", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    DropDownList1.Items.Add(dr.GetString(i));
                }
            }
            dr.Close();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtenroll.Text != "" && DropDownList1.Text != "")
            {


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into issuereturnbook values(@senroll,@bname,@issuedate,@returndate)", con);
                cmd.Parameters.AddWithValue("@senroll", txtenroll.Text);
                cmd.Parameters.AddWithValue("@bname", DropDownList1.Text);
                cmd.Parameters.AddWithValue("@issuedate", Calendar1.SelectedDate.Date.ToString());

                cmd.Parameters.AddWithValue("@returndate", Calendar2.SelectedDate.Date.ToString());

                cmd.ExecuteNonQuery();
                Response.Write("succcesfully Issued Book");
                con.Close();
            }
            else
            {
                Response.Write("Empty field not allowwd!!");
            }
        }
    }
}