using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManage
{
    public partial class LabSafetyInfoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = ADOHelp.QueryDataTable("SELECT LabSafetyID,LabSafetyTitle FROM LabSafetyInfo");
            Repeater1.DataBind();
        }
    }
}
