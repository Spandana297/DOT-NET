using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Services;


namespace WebApplication1
{ 
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       //public static void GetMenu()
       // {
       //     List<MenuDetailes> listmenu = new List<MenuDetailes>();
        
       // using (SqlConnection con = new SqlConnection("Data Source=20Q1S8JPC1KK4R8;Initial Catalog=MyAPP_db;Integrated Security=True"))
       //     {
       //         SqlCommand comm = new SqlCommand("select * from Menu", con);
       //         con.Open();
       //         SqlDataReader rde = comm.ExecuteReader();
       //         while (rde.Read())
       //         {
       //             MenuDetailes menu = new MenuDetailes();
       //             menu.ID = Convert.ToInt32(rde["ID"]);
       //             menu.Cusine_Name = Convert.ToInt32(rde["Cusine_Name"]);
       //             menu.Cusine_Type = Convert.ToInt32(rde["Cusine_Type"]);
       //             menu.Cost = Convert.ToInt32(rde["Cost"]);
       //             listmenu.Add(menu);
       //         }
       //     }

       //     JavaScriptSerializer js = new JavaScriptSerializer();
       //    // Context.Request.Write(js.Serialize(listmenu));
        
        
        
       // }    
    }
}