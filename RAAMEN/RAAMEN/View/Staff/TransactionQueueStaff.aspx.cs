using RAAMEN.Controller;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Staff
{
    public partial class TransactionQueueStaff : System.Web.UI.Page
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
                Response.Redirect("StaffHome.aspx");
                return;
            }
            else
            {
                user = (User)Session["User"];
            }

            TransactionGV.DataSource = TransactionController.getAllTransaction();
            TransactionGV.DataBind();
        }

        protected void TransactionGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = TransactionGV.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[1].Text);
            int staffid = (int)Session["UserId"];
            
            TransactionController.handleTransaction(id,staffid);
            Response.Redirect("TransactionQueueStaff.aspx");

        }
    }
}