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

namespace WebApplication1
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string SaveMenu(MenuDetailes menus)
        {

            string result = string.Empty;
            using (SqlConnection con = new SqlConnection("Data Source=20Q1S8JPC1KK4R8;Initial Catalog=MyAPP_db;Integrated Security=True"))
            {
                SqlCommand comm = new SqlCommand("spSaveMenu", con);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@ID",
                    Value = menus.ID
                }
                    );
                comm.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Cusine_Name",
                    Value = menus.Cusine_Name
                }
                   );
                comm.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Cusine_Type",
                    Value = menus.Cusine_Type
                }
                 );
                comm.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Cost",
                    Value = menus.Cost
                }
                );
                con.Open();
                comm.ExecuteNonQuery();
                result = "Data Saved Successfully.....";
            }
            return result;

        }

        [WebMethod]
        public static string SaveMenuInDB(string ID,string cusName,string cusType,string cost)
        {

            string result = string.Empty;
            using (SqlConnection con = new SqlConnection("Data Source=20Q1S8JPC1KK4R8;Initial Catalog=MyAPP_db;Integrated Security=True"))
            {
                SqlCommand comm = new SqlCommand("spSaveMenu", con);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@ID",
                    Value = ID
                }
                    );
                comm.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Cusine_Name",
                    Value = cusName
                }
                   ) ;
                comm.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Cusine_Type",
                    Value =cusType
                }
                 );
                comm.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Cost",
                    Value =cost
                }
                );
                con.Open();
                comm.ExecuteNonQuery();
               
            }
            result = "Data Saved Successfully.....";
            return result;

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public static string GetMenu()
        {
            string result = string.Empty;
            List<MenuDetailes> listmenu = new List<MenuDetailes>();

            using (SqlConnection con = new SqlConnection("Data Source=20Q1S8JPC1KK4R8;Initial Catalog=MyAPP_db;Integrated Security=True"))
            {
                SqlCommand comm = new SqlCommand("select * from Menu", con);
                con.Open();
                SqlDataReader rde = comm.ExecuteReader();
                while (rde.Read())
                {
                    MenuDetailes menu = new MenuDetailes();
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
