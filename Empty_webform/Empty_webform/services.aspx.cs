using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Empty_webform
{
    public partial class services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltrservice.Text = " We Have the following service for You";
            Label1.Text = " Please select the one which suits you";
        }

      
        protected void service1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Redirect("Room_Booking.aspx");
        }
        protected void service2_CheckedChanged(object sender, EventArgs e)
        {
            Response.Redirect("SpaServices.aspx");
        }

        protected void service3_CheckedChanged(object sender, EventArgs e)
        {
            Response.Redirect("PartyHall Booking.aspx");
        }

        protected void service4_CheckedChanged(object sender, EventArgs e)
        {
           Response.Redirect("Menu.aspx");
        }

        
    }
}