using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Menud1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      





        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public static string GetMenu()
        {
            string result = string.Empty;
            List<Menu> listmenu = new List<Menu>();

            using (SqlConnection con = new SqlConnection("Data Source=20Q1S8JPC1KK4R8;Initial Catalog=MyAPP_db;Integrated Security=True"))
            {
                SqlCommand comm = new SqlCommand("select * from Menu", con);
                con.Open();
                SqlDataReader rde = comm.ExecuteReader();
                while (rde.Read())
                {
                    Menu menu = new Menu();
                    menu.ID = rde["ID"].ToString();
                    menu.Cusine_Name = rde["Cusine_Name"].ToString();
                    menu.Cusine_Type = rde["Cusine_Type"].ToString();
                    menu.Cost = rde["Cost"].ToString();
                    listmenu.Add(menu);
                }
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            result = js.Serialize(listmenu);
            return result;
        }
    }
}