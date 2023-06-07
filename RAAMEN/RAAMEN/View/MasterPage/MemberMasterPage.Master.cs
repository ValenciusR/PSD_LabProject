using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.MasterPage
{
    public partial class MemberMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            // Response.Redirect("");
        }

        protected void HistoryBtn_Click(object sender, EventArgs e)
        {
            // Response.Redirect("");
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Profile.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            HttpCookie cookie = Request.Cookies["DataUser"];
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Session.Clear();
            Response.Redirect("../Login.aspx");
        }
    }
}