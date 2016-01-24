using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LabManage
{
    public partial class BackTeacherAppointment : System.Web.UI.Page
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
            AspNetPager1.RecordCount = Convert.ToInt32(ADOHelp.GetSingle("proc_proc_SearchTeacherAppointmentListCount"));
            Repeater1.DataSource = ADOHelp.QueryDataTable("exec proc_SearchTeacherAppointmentList " + AspNetPager1.PageSize + "," + AspNetPager1.CurrentPageIndex + "");
            Repeater1.DataBind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BindData();
        }

      
    }
}
