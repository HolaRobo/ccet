using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LabManage
{
    public partial class BackLabInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   
                //
                BindLabType();
                //绑定数据
                BindData();
            }
        }
  
        private void BindData()
        {
            AspNetPager1.RecordCount = Convert.ToInt32(ADOHelp.GetSingle("proc_BackSearchLabInfoCount '" + TextBox1.Text + "' "));
            Repeater1.DataSource = ADOHelp.QueryDataTable("exec proc_BackSearchLabInfo " + AspNetPager1.PageSize + "," + AspNetPager1.CurrentPageIndex + ",'" + TextBox1.Text + "'");
            Repeater1.DataBind();
        }
        //绑定实验室类型
        private void BindLabType()
        {
            DataTable dt_type = ADOHelp.QueryDataTable("SELECT LabTypeID,LabTypeName FROM LabInfo_LabType");
            foreach (DataRow dr in dt_type.Rows)
            {
                DropDownList1.DataSource = dt_type;
                DropDownList1.DataTextField = "LabTypeName";
                DropDownList1.DataValueField = "LabTypeID";
                DropDownList1.DataBind();
            }
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
