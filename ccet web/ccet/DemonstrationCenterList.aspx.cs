using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManage
{
    public partial class DemonstrationCenterList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }

            AspNetPager1.PrevPageText = "上一页";
            AspNetPager1.LastPageText = "尾页";
            AspNetPager1.FirstPageText = "首页";
            AspNetPager1.NextPageText = "下一页";
        }

        private void BindData()
        {
            //

            AspNetPager1.RecordCount = Convert.ToInt32(ADOHelp.GetSingle("select count(DCID) from DemonstrationCenter"));

            Repeater1.DataSource = ADOHelp.QueryDataTable("exec proc_SearchAllDCList " + AspNetPager1.PageSize + "," + AspNetPager1.CurrentPageIndex + " ");
            Repeater1.DataBind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BindData();
        }
    }
}