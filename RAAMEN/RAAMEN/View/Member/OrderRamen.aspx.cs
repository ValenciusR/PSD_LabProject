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
        public static int[] ramenIdArr = new int[400];
        public static int[] ramenQtyArr = new int[400];
        int globalCountOrder = 0;

        ArrayList ramensId = new ArrayList();
        ArrayList ramensQty = new ArrayList();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            RamenView.DataSource = RamenController.getAllRamen();
            RamenView.DataBind();
        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            int customerId = (int)Session["UserId"];
            //TransactionController.makeTransaction(customerId, ramenIdArr, ramenQtyArr, globalCountOrder);
            TransactionController.makeTransaction(customerId, ramensId, ramensQty);
            ramensId.Clear();
            ramensQty.Clear();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            ramenIdArr[globalCountOrder] = (int.Parse(ramenId.Text));
            ramenQtyArr[globalCountOrder] = (int.Parse(ramenQty.Text));
            globalCountOrder++;

            ramensId.Add(int.Parse(ramenId.Text));
            ramensQty.Add(int.Parse(ramenId.Text));
            //gw gatau apakah kalo ke redirect bakal ilang data dalam arraynya
            Response.Redirect("OrderRamen.aspx");
        }
    }
}