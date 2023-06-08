using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Admin
{
    public partial class ManageRamenAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ramenGV.DataSource = RamenController.getAllRamen();
            ramenGV.DataBind();
        }

        protected void ramenGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = ramenGV.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[1].Text);
            Response.Redirect("UpdateRamenAdmin.aspx?id=" + id);
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertRamenAdmin.aspx");
        }

        protected void ramenGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = ramenGV.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[1].Text);
            RamenController.deleteRamen(id);
            Response.Redirect("ManageRamenAdmin.aspx");
        }
    }
}