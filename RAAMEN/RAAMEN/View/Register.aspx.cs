using RAAMEN.Controller;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class Register : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["DataUser"];
            if (Session["UserRole"] != null)
            {
                if (Convert.ToInt32(Session["UserRole"]) == 1)
                {
                    Response.Redirect("Admin/AdminHome.aspx");
                    return;
                }
                else if (Convert.ToInt32(Session["UserRole"]) == 2)
                {
                    Response.Redirect("Staff/StaffHome.aspx");
                    return;
                }
                else if (Convert.ToInt32(Session["UserRole"]) == 3)
                {
                    Response.Redirect("Member/MemberHome.aspx");
                    return;
                }
            }
            else if (cookie != null)
            {
                User user;
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
                if (Convert.ToInt32(cookie["Role"]) == 1)
                {
                    Response.Redirect("Admin/AdminHome.aspx");
                    return;
                }
                else if (Convert.ToInt32(cookie["Role"]) == 2)
                {
                    Response.Redirect("Staff/StaffHome.aspx");
                    return;
                }
                else if (Convert.ToInt32(cookie["Role"]) == 3)
                {
                    Response.Redirect("Member/MemberHome.aspx");
                    return;
                }
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (RadioMale.Checked == true)
            {
                gender = RadioMale.Text;
            }
            else if (RadioFemale.Checked == true)
            {
                gender = RadioFemale.Text;
            }
            string result = UserController.InsertUser(NameTxb.Text, EmailTxb.Text, gender, PassTxb.Text, ConfirmTxb.Text);
            status.Text = result;
            if(result == "")
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}