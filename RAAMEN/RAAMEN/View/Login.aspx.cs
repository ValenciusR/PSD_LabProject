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
    public partial class Login : System.Web.UI.Page
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
            else if(cookie != null)
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

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            User user = (from u in db.Users where u.Username.Equals(NameTxb.Text) && u.Password.Equals(PassTxb.Text) select u).FirstOrDefault();
            bool RememberMe = RememberMeCheckBox.Checked;
            if (user != null)
            {
                Session["User"] = user;
                Session["UserRole"] = user.RoleId;
                Session["UserId"] = user.Id;

                if (RememberMe)
                {
                    HttpCookie cookies = new HttpCookie("DataUser");
                    cookies["Role"] = user.RoleId.ToString();
                    cookies["UserId"] = user.Id.ToString();
                    cookies.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookies);
                }

                if (user.RoleId == 1)
                {
                    Response.Redirect("Admin/AdminHome.aspx");
                }
                else if (user.RoleId == 2)
                {
                    Response.Redirect("Staff/StaffHome.aspx");
                }
                else if (user.RoleId == 3)
                {
                    Response.Redirect("Member/MemberHome.aspx");
                }
            }
            else
            {
                status.Text = "Username or password is incorrect";
            }
        }

        protected void RegisterLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}