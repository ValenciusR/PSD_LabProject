using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Staff
{
    public partial class ProfileStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int id = (int)Session["UserId"];
            string name = NameTxb.Text;
            string email = EmailTxb.Text;
            string gender = "";
            if (RadioMale.Checked == true)
            {
                gender = RadioMale.Text;
            }
            else if (RadioFemale.Checked == true)
            {
                gender = RadioFemale.Text;
            }
            string pass = PassTxb.Text;
            status.Text = UserController.UpdateUser(id, name, email, gender, pass);
        }
    }
}