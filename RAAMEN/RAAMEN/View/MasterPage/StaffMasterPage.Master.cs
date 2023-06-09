using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.MasterPage
{
    public partial class StaffMasterPage : System.Web.UI.MasterPage
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
            else if (Convert.ToInt32(Session["UserRole"]) == 1)
            {
                Response.Redirect("../Admin/AdminHome.aspx");
                return;
            }
            else if (Convert.ToInt32(Session["UserRole"]) == 3)
            {
                Response.Redirect("../Member/MemberHome.aspx");
                return;
            }

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
        }
        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffHome.aspx");
        }

        protected void ManageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamenAdmin.aspx");
        }

        protected void QueueBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionQueueStaff.aspx");
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfileStaff.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            HttpCookie cookie = Request.Cookies["DataUser"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }
            Session.Clear();
            Response.Redirect("../Login.aspx");
        }
    }
}