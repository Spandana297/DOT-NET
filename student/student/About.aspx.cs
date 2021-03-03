using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=20Q1S8JPC1KK4R8;Initial Catalog=programmingDB;Integrated Security=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into Studentinfo_Tab values(" + int.Parse(TextBox1.Text) + ",'" +double.Parse(TextBox2.Text) + "')";
            SqlCommand comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            con.Close();

            string message = "Your details have been saved successfully.";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += Request.Url.AbsoluteUri;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        }
    }
}