using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManage
{
    public partial class ResourceDown : System.Web.UI.Page
    {
        string TypeName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                TypeName = Request.QueryString["TypeName"].Trim();
               
            }
            catch { }
            if (!IsPostBack)
            {

                Repeater1.DataSource = ADOHelp.QueryDataTable("exec proc_SearchResourceFile '" + TypeName + "'");
                Repeater1.DataBind();
                Select1.Value = TypeName;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("ResourceDown.aspx?TypeName=" + Select1.Value);
        }

    }
}
