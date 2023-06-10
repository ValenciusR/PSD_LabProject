using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Admin
{
    public partial class AdminHome : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["DataUser"];
            if (Session["User"] == null && cookie == null)
            {
                Response.Redirect("../Login.aspx");
                return;
            }

            // Kalau butuh data user dari session
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
            user = (User)Session["User"];
            NameLbl.Text = user.Username;
            //

            List<User> staffs = new List<User>();
            staffs = (from u in db.Users where u.RoleId.Equals(2) select u).ToList<User>();
            StaffView.DataSource = staffs;
            StaffView.DataBind();
        }
    }
}