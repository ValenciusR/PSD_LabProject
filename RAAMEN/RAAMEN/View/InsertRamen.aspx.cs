using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class InsertRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MeatDdl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            string name = NameTb.Text;
            int meatId = int.Parse(MeatDdl.SelectedValue);
            string broth = BrothTb.Text;
            int price = int.Parse(PriceTb.Text);
            String result = RamenController.insertRamen(meatId, name, broth, price);
            StatusLbl.Text = result;
            if (result == "Success")
            {
                Response.Redirect("/View/ManageRamen.aspx");
            }
        }
    }
}