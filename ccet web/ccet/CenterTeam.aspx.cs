using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManage
{
    public partial class CenterTeam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = ADOHelp.GetSingle("select  top 1 CenterTeam from dbo.SysSet ").ToString();
        }
    }
}
