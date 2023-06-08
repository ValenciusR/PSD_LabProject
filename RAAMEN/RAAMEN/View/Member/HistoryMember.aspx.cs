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
            CustomerHistory.DataSource = null;
            //kurang bikin getTransactionByCustomerId
        }
    }
}