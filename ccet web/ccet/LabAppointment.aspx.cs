using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManage
{
    public partial class LabAppointment : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            //存储过程  proc_LabLabAppointmentInfo
            int LabID = 0;
            try
            {
                LabID = Convert.ToInt32(Request.QueryString["LabID"]);
                Label1.Text=Request.QueryString["LabName"];
            }
            catch { }
            if (!IsPostBack)
            {
                Repeater1.DataSource = ADOHelp.QueryDataTable("exec proc_LabLabAppointmentInfo " + LabID + "");
                Repeater1.DataBind();
            }
        }
    }
}
