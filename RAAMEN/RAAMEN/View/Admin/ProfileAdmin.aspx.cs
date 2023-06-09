﻿using RAAMEN.Controller;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Admin
{
    public partial class ProfileAdmin : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user;
            HttpCookie cookie = Request.Cookies["DataUser"];
            if (Session["User"] == null && cookie == null)
            {
                Response.Redirect("../Login.aspx");
                return;
            }
            if (Session["User"] == null)
            {
                var id = Convert.ToInt32(cookie["UserId"]);
                user = (from u in db.Users where u.Id.Equals(id) select u).FirstOrDefault();
                Session["User"] = user;
                Session["UserRole"] = user.RoleId;
                Session["UserId"] = user.Id;
            }
            else
            {
                user = (User)Session["User"];
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["UserId"]);
            string name = NameTxb.Text;
            string email = EmailTxb.Text;
            string gender = "";
            if (RadioMale.Checked == true)
            {
                gender = RadioMale.Text;
            }
            else if (RadioFemale.Checked == true)
            {
                gender = RadioFemale.Text;
            }
            string pass = PassTxb.Text;
            string oldpass = OldPassTxb.Text;
            status.Text = UserController.UpdateUser(id, name, email, gender, pass, oldpass);

            if(status.Text == "User update success!")
            {
                User user = (from u in db.Users where u.Id.Equals(id) select u).FirstOrDefault();
                Session["User"] = user;
                Session["UserRole"] = user.RoleId;
                Session["UserId"] = user.Id;
            }
        }
    }
}