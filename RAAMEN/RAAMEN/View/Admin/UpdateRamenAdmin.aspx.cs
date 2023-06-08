using RAAMEN.Controller;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Admin
{
    public partial class UpdateRamenAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"]);
                Raman ramen = RamenController.getRamenById(id);
                NameTb.Text = ramen.Name;
                meatIdDDl.SelectedValue = ramen.MeatId.ToString();
                BrothTb.Text = ramen.Broth;
                PriceTb.Text = ramen.Price.ToString();
            }
        }

        protected void UpdateBtn_Click1(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            string name = NameTb.Text;
            int meatId = int.Parse(meatIdDDl.SelectedValue);
            string broth = BrothTb.Text;
            int price = int.Parse(PriceTb.Text);
            String result = RamenController.updateRamen(id, meatId, name, broth, price);
            StatusLbl.Text = result;
            if (result == "Success")
            {
                Response.Redirect("ManageRamenAdmin.aspx");
            }
        }
    }
}