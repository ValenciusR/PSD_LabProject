using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Admin
{
    public partial class HistoryAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AdminHistory.DataSource = TransactionController.getAllTransaction();
            AdminHistory.DataBind();
        }

        protected void AdminHistory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = AdminHistory.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[1].Text);
            //bug -> gabisa return response
            Response.Redirect("HistoryAdminTransactionDetail.aspx?id="+id);
        }
    }
}