using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LabManage
{
    public partial class MyAppointment : System.Web.UI.Page
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
            if (Request.Cookies["CookieUserID"] != null)
            {
                Repeater1.DataSource = ADOHelp.QueryDataTable("exec proc_SearchMyAppointment " + Convert.ToInt32(Request.Cookies["CookieUserID"].Value) + "");
                Repeater1.DataBind();
            }
        }

      
    }
}
