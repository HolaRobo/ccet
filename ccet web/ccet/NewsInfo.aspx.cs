using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LabManage
{
    public partial class NewsInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int NewsID =Convert.ToInt32(Request.QueryString["NewsID"]);
                DataTable dt = ADOHelp.QueryDataTable("exec proc_SearchNewsInfo_ToNewsID " + NewsID + "");
                if (dt.Rows.Count > 0)
                {
                    Label1.Text = dt.Rows[0]["NewsTitle"].ToString();
                    Label2.Text = dt.Rows[0]["PublicTime"].ToString();
                    Label3.Text = dt.Rows[0]["NewsContent"].ToString();
                }
            }
        }
    }
}
