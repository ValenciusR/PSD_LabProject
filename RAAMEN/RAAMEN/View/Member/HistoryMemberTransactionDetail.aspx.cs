using RAAMEN.Controller;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Member
{
    public partial class HistoryMemberTransactionDetail : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user;
            HttpCookie cookie = Request.Cookies["DataUser"];
            if (Session["User"] == null && cookie == null)
            {
                Response.Redirect("../Login.aspx");
                return;
            }
            if (Session["User"] == null)
            {
                Response.Redirect("HistoryMember.aspx");
                return;
            }
            else
            {
                user = (User)Session["User"];
            }

            int headerId = int.Parse(Request.QueryString["id"]);

            detailTransaction.DataSource = TransactionController.getAllDetailTransactionByHeaderId(headerId);
            detailTransaction.DataBind();
        }
    }
}