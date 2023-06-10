using CrystalDecisions.CrystalReports.Engine;
using RAAMEN.Model;
using RAAMEN.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN.View.Admin
{
    public partial class ViewReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseEntities db = new DatabaseEntities();
            HttpCookie cookie = Request.Cookies["DataUser"];
            User user;
            if (Session["User"] == null && cookie == null)
            {
                Response.Redirect("../Login.aspx");
                return;
            }
            else if (Session["User"] == null)
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
            CrystalReport report = new CrystalReport();
            CrystalReportViewer.ReportSource = report;

            DataSet data = getData((from header in db.Headers select header).ToList());

            report.SetDataSource(data);

        }

        private DataSet getData(List<Header> headers)
        {
            DataSet data = new DataSet();
            var headerTable = data.Header;
            var detailTable = data.Detail;



            foreach (Header h in headers)
            {
                var headerRow = headerTable.NewRow();
                headerRow["Id"] = h.Id;
                headerRow["CustomerId"] = h.CustomerId;
                headerRow["StaffId"] = h.StaffId;
                headerRow["Date"] = h.Date;
                headerRow["Status"] = h.Status;
                headerTable.Rows.Add(headerRow);

                foreach (Detail d in h.Details)
                {
                    var detailRow = detailTable.NewRow();
                    detailRow["HeaderId"] = d.HeaderId;
                    detailRow["RamenId"] = d.RamenId;
                    detailRow["Quantity"] = d.Quantity;
                    detailRow["Price"] = d.Raman.Price * d.Quantity;
                    detailTable.Rows.Add(detailRow);
                }

            }
            return data;
        }
    }
}