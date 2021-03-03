using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }
        SqlConnection con = new SqlConnection("Data Source=20Q1S8JPC1KK4R8;Initial Catalog=programmingDB;Integrated Security=True");

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            string query = "Insert into Studentinfo_Tab values(" + int.Parse(TextBox1.Text) + ",'" + TextBox2.Text + "','" + DropDownList1.SelectedValue + "'," + int.Parse(TextBox3.Text) + ",'" + TextBox4.Text + "')";
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
            LoadRecord();
            



        }

        void LoadRecord()
        {
             
            SqlCommand comm = new SqlCommand("select * from Studentinfo_Tab", con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable ds = new DataTable();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Update Studentinfo_Tab set StudentName ='" + TextBox2.Text + "',State ='" + DropDownList1.SelectedValue + "', Age = '" + int.Parse(TextBox3.Text) + "', Contact = '" + TextBox4.Text + "' where StudentID='"+int.Parse(TextBox1.Text)+"'";
            SqlCommand comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            con.Close();
            
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Updated');", true);
            LoadRecord();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Delete Studentinfo_Tab  where StudentID='" + int.Parse(TextBox1.Text) + "'";
            SqlCommand comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Deleted');", true);
            LoadRecord();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("select * from Studentinfo_Tab where StudentID='" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable ds = new DataTable();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}