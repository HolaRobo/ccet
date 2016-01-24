using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManage
{
    public partial class BackSystemAndSafety : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string Commmand = Request.QueryString["Command"].Trim();
                    Repeater1.DataSource = ADOHelp.QueryDataTable("exec proc_BackSearchSystemAndSafety  '" + Commmand + "'");
                    Repeater1.DataBind();
                }
                catch
                {
                    Server.Transfer("404error.htm");
                }
            }
        }
    }
}
