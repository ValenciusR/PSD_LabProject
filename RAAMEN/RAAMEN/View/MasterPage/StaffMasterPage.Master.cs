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
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffHome.aspx");
        }

        protected void ManageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ManageRamen.aspx");
        }

        protected void QueueBtn_Click(object sender, EventArgs e)
        {
            // Response.Redirect("namafile.aspx");
        }

        protected void Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Profile.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("../Login.aspx");
        }
    }
}