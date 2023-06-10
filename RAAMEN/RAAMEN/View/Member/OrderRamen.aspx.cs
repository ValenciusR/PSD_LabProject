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

        public static ArrayList ramensId = new ArrayList();
        public static ArrayList ramensQty = new ArrayList();

        public static ArrayList ramenss = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
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