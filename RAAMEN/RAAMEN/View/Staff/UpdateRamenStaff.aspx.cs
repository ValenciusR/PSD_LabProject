using RAAMEN.Controller;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Staff
{
    public partial class UpdateRamenStaff : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["DataUser"];
            User user;
            if (Session["User"] == null && cookie == null)
            {
                Response.Redirect("../Login.aspx");
                return;
            }
            if (Session["User"] == null)
            {
                Response.Redirect("ManageRamenStaff.aspx");
                return;
            }
            else
            {
                user = (User)Session["User"];
            }
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
                Response.Redirect("ManageRamenStaff.aspx");
            }
        }
    }
}