using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Staff
{
    public partial class StaffHome : System.Web.UI.Page
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
            else if (Convert.ToInt32(cookie["Role"]) == 1)
            {
                Response.Redirect("../Admin/AdminHome.aspx");
                return;
            }
            else if (Convert.ToInt32(cookie["Role"]) == 3)
            {
                Response.Redirect("../Member/MemberHome.aspx");
                return;
            }

            // Kalau butuh data user dari session
            User user;
            if (Session["User"] == null)
            {
                var id = Convert.ToInt32(cookie["UserId"]);
                user = (from u in db.Users where u.Id.Equals(id) select u).FirstOrDefault();
                Session["User"] = user;
            }
            else
            {
                user = (User)Session["User"];
            }
            NameLbl.Text = user.Username;
            //

            List<User> members = new List<User>();
            members = (from u in db.Users where u.RoleId.Equals(3) select u).ToList<User>();
            MemberView.DataSource = members;
            MemberView.DataBind();
        }
    }
}