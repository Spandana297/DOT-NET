using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Empty_webform
{
    public partial class Menu : System.Web.UI.Page
    {
        static SqlConnection con = new SqlConnection("Data Source=20Q1S8JPC1KK4R8;Initial Catalog=MyAPP_db;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        [WebMethod]
       public static string InsertRecords(string ID,string Cusine_Name,string Cusine_Type,string Cost)
        {
            con.Open();
            string query = "Insert into Menu values('"+ID+ "',' "+ Cusine_Name +" ','"+ Cusine_Type +"','"+Cost +"')";
            SqlCommand comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            con.Close();
            return "Submit";
           
            
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into Menu values('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "','" + DropDownList1.SelectedValue + "'," + double.Parse(TextBox3.Text) + ")";
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Update Menu set Cusine_Name ='" + TextBox2.Text + "',Cusine_Type ='" + DropDownList1.SelectedValue + "', Cost = '" + double.Parse(TextBox3.Text) + "' where ID='" + int.Parse(TextBox1.Text) + "'";
            SqlCommand comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Updated');", true);
            //LoadRecord();

        }
    }
}