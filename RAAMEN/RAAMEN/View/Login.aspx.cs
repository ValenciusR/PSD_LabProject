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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            DatabaseEntities db = new DatabaseEntities();
            User user = (from u in db.Users where u.Email.Equals(EmailTxb.Text) && u.Password.Equals(PassTxb.Text) select u).FirstOrDefault();
            if (user == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
            HttpCookie cookies = new HttpCookie("DataUser");
            cookies["Role"] = user.RoleId.ToString();
            cookies.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookies);

            Session["UserRole"] = user.RoleId;
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
                Response.Redirect("Customer/CustomerHome.aspx");
            }
        }
    }
}