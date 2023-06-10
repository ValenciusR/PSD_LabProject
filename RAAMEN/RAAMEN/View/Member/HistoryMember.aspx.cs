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
    public partial class HistoryMember : System.Web.UI.Page
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
            int customerId = (int)Session["UserId"];
            CustomerHistory.DataSource = TransactionController.getAllTransactionByCustomerId(customerId);
            CustomerHistory.DataBind();
        }

        protected void CustomerHistory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = CustomerHistory.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[1].Text);
            Response.Redirect("HistoryMemberTransactionDetail.aspx?id="+id);
        }
    }
}