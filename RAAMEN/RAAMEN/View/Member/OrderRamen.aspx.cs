using RAAMEN.Controller;
using RAAMEN.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Member
{
    public partial class OrderRamen : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        public static ArrayList ramensId = new ArrayList();
        public static ArrayList ramensQty = new ArrayList();

        public static ArrayList ramenss = new ArrayList();
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
            RamenView.DataSource = RamenController.getAllRamen();
            RamenView.DataBind();

            RamensOrder.DataSource = ramenss;
            RamensOrder.DataBind();
        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            int customerId = (int)Session["UserId"];
            TransactionController.makeTransaction(customerId, ramensId, ramensQty);
            ramensId.Clear();
            ramensQty.Clear();
            ramenss.Clear();
            Response.Redirect("OrderRamen.aspx");
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            ramensId.Add(int.Parse(ramenId.Text));
            ramensQty.Add(int.Parse(ramenQty.Text));
            ramenss.Add(new Ramen(int.Parse(ramenId.Text), int.Parse(ramenQty.Text)));
            
            Response.Redirect("OrderRamen.aspx");
        }
    }
}