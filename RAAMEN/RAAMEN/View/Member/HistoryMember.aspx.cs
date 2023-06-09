using RAAMEN.Controller;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            int customerId = (int)Session["UserId"];
            CustomerHistory.DataSource = TransactionController.getAllTransactionByCustomerId(customerId);
            CustomerHistory.DataBind();
        }

        protected void CustomerHistory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = CustomerHistory.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[1].Text);
            Response.Redirect("MemberHome.aspx");
        }
    }
}