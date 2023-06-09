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
    public partial class AdminMasterPage : System.Web.UI.MasterPage
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
            else if (Convert.ToInt32(Session["UserRole"]) == 3)
            {
                Response.Redirect("../Member/MemberHome.aspx");
                return;
            }
            else if (Convert.ToInt32(Session["UserRole"]) == 2)
            {
                Response.Redirect("../Staff/StaffHome.aspx");
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
            Response.Redirect("AdminHome.aspx");
        }

        protected void ManageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamenAdmin.aspx");
        }

        protected void QueueBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionQueueAdmin.aspx");
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfileAdmin.aspx");
        }

        protected void HistoryBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("HistoryAdmin.aspx");
        }
        protected void ReportBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewReport.aspx");
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