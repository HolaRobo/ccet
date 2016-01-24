using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LabManage
{
    public partial class BackTeacherInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   

                //绑定数据
                BindData();
            }
        }
  
        private void BindData()
        {
            AspNetPager1.RecordCount = Convert.ToInt32(ADOHelp.GetSingle("proc_BackSearchTeacherInfoCount '" + TextBox1.Text + "' "));
            Repeater1.DataSource = ADOHelp.QueryDataTable("exec proc_BackSearchTeacherInfo " + AspNetPager1.PageSize + "," + AspNetPager1.CurrentPageIndex + ",'" + TextBox1.Text + "'");
            Repeater1.DataBind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BindData();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BindData();
        }

      
    }
}
