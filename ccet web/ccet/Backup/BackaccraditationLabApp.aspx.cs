using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LabManage
{
    public partial class BackaccraditationLabApp : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {

            int AppointmentID = 0;
            try
            {
                AppointmentID = Convert.ToInt32(Request.QueryString["AppointmentID"]);
            }
            catch { }
            if (!IsPostBack)
            {   
                //提取改预约的详细信息
                DataTable dt = ADOHelp.QueryDataTable("exec proc_SearchLabAppointment_ToAppointmentID "+AppointmentID+"");
                if (dt.Rows.Count > 0)
                {
                    Label1.Text = dt.Rows[0]["TeacherName"].ToString();
                    Label2.Text = dt.Rows[0]["AppointmentDate"].ToString();
                    Label3.Text = dt.Rows[0]["LabName"].ToString();
                    Label4.Text = dt.Rows[0]["LabTypeName"].ToString();
                    Label5.Text = dt.Rows[0]["TeacherLeaveMessage"].ToString();
                    Label6.Text = dt.Rows[0]["AdminAllow"].ToString();
                    Label7.Text = dt.Rows[0]["AdminReason"].ToString();
                }
            }
        }
    }
}
