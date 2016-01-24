using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LabManage
{
    public partial class CenterframeworkInfo : System.Web.UI.Page
    {
        int CenterframeworkID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["CenterframeworkID"] == null)
                {
                    CenterframeworkID = 1;
                }
                CenterframeworkID = Convert.ToInt32(Request.QueryString["CenterframeworkID"]);
                DataTable dt = ADOHelp.QueryDataTable("exec procSearchCenterframeworkData " + CenterframeworkID + "");
                Label1.Text = dt.Rows[0]["CenterframeworkName"].ToString();
                Label2.Text = dt.Rows[0]["CenterframeworkContent"].ToString();
            }
            catch { }
        }
    }
}
