using RAAMEN.Controller;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class OrderRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RamenView.DataSource = RamenController.getAllRamen();
            RamenView.DataBind();
        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            int customerId = (int)Session["UserId"];
            TransactionController.makeTransaction(customerId);

        }
    }
}