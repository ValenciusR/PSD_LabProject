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
    }
}