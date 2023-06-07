using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Member
{
    public partial class MemberHome : System.Web.UI.Page
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
            else if(Convert.ToInt32(cookie["Role"]) == 1)
            {
                Response.Redirect("../Admin/AdminHome.aspx");
                return;
            }
            else if (Convert.ToInt32(cookie["Role"]) == 2)
            {
                Response.Redirect("../Staff/StaffHome.aspx");
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
        }
    }
}