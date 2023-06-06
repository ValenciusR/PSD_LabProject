using RAAMEN.Controller;
using RAAMEN.Model;
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
            // User checkUser = UserController.getUserByName(EmailTxb.Text);
            if (RadioMale.Checked == true)
            {
                gender = RadioMale.Text;
            }
            else if (RadioFemale.Checked == true)
            {
                gender = RadioFemale.Text;
            }

            if (NameTxb.Text == "" || EmailTxb.Text == "" || gender == "" || PassTxb.Text == "" || ConfirmTxb.Text == "")
            {
                status.Text = "You must fill in all in the form!";
            }
            else if (PassTxb.Text != "" && ConfirmTxb.Text != "" && PassTxb.Text != ConfirmTxb.Text)
            {
                status.Text = "Password input must be the same input with Confirm Password!";
            }
            // else if(checkUser != null)
            // {
                // status.Text = "User already exists!";
            // }
            else
            {
                UserController.InsertUser(NameTxb.Text, EmailTxb.Text, gender, PassTxb.Text);

                Response.Redirect("Login.aspx");
            }
        }
    }
}