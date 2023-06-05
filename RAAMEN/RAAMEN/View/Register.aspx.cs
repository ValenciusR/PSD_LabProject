using RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (RadioMale.Checked == true)
            {
                gender = RadioMale.Text;
            }
            else if (RadioFemale.Checked == true)
            {
                gender = RadioFemale.Text;
            }
            status.Text = UserController.RegisterUser(NameTxb.Text, EmailTxb.Text, ConfirmTxb.Text, gender, PassTxb.Text);
        }
    }
}