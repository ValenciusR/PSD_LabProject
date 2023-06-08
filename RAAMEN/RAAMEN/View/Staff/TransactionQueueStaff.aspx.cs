using RAAMEN.Controller;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionGV.DataSource = TransactionController.getAllTransaction();
            TransactionGV.DataBind();
        }

        protected void TransactionGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = TransactionGV.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[1].Text);
            TransactionController.handleTransaction(id);
            Response.Redirect("TransactionQueue.aspx");

        }
    }
}