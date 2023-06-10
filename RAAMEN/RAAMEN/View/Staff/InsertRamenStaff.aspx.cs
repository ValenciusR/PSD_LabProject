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
    public partial class InsertRamenStaff : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user;
            HttpCookie cookie = Request.Cookies["DataUser"];
            if (Session["User"] == null && cookie == null)
            {
                Response.Redirect("../Login.aspx");
                return;
            }
            if (Session["User"] == null)
            {
                var id = Convert.ToInt32(cookie["UserId"]);
                user = (from u in db.Users where u.Id.Equals(id) select u).FirstOrDefault();
                Session["User"] = user;
                Session["UserRole"] = user.RoleId;
                Session["UserId"] = user.Id;
            }
            else
            {
                user = (User)Session["User"];
            }
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
                Response.Redirect("ManageRamenStaff.aspx");
            }
        }
    }
}