using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userRole = (int)Session["UserRole"];
            AdminHistory.DataSource = TransactionController.getAllTransaction();
            AdminHistory.DataBind();

            CustomerHistory.DataSource = null;
            //kurang bikin getTransactionByCustomerId

            if(userRole == 1)
            {
                CustomerHistory.Visible = false;
            }
            else if(userRole == 3){
                AdminHistory.Visible = false;
            }
            else
            {
                AdminHistory.Visible = false;
                CustomerHistory.Visible = false;
            }
        }
    }
}