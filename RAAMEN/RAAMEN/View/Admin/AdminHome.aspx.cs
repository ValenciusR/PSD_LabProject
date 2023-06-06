﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Admin
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["DataUser"];

            if (cookie == null)
            {
                Response.Redirect("View.Login.aspx");
                return;
            }

            string temp = Session["UserRole"].ToString();
        }
    }
}