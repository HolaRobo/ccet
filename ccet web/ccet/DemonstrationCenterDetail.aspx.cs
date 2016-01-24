using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManage
{
    public partial class DemonstrationCenterDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int DCID = Convert.ToInt32(Request.QueryString["DCID"]);
                DataTable dt = ADOHelp.QueryDataTable("select Top 1 * from DemonstrationCenter where DCID=" + DCID);
                if (dt.Rows.Count > 0)
                {
                    Label1.Text = dt.Rows[0]["DCTitle"].ToString();
                    Label2.Text = dt.Rows[0]["PublicTime"].ToString();
                    Label3.Text = dt.Rows[0]["DCContent"].ToString();
                }
            }
        }
    }
}