using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LabManage
{
    public partial class LabSafetyInfo : System.Web.UI.Page
    {
        int d_LabSafetyID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                d_LabSafetyID = Convert.ToInt32(Request.QueryString["LabSafetyID"]);
                DataTable dt = ADOHelp.QueryDataTable("exec proc_SearchLabSafetyInfo " + d_LabSafetyID + "");
                Label1.Text = dt.Rows[0]["LabSafetyTitle"].ToString();
                Label2.Text = dt.Rows[0]["LabSafetyContent"].ToString();
            }
            catch { }
        }
    }
}
