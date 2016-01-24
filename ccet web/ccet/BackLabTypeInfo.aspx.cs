using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LabManage
{
    public partial class BackLabTypeInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   
     
                BindData();
            }
        }
  
        private void BindData()
        {

            Repeater1.DataSource = ADOHelp.QueryDataTable("SELECT LabTypeID,LabTypeName FROM LabInfo_LabType ");
            Repeater1.DataBind();
        }



      
    }
}
