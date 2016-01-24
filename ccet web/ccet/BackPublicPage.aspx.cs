using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LabManage
{
    public partial class BackPublicPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //int NewsID = Convert.ToInt32(Request.QueryString["NewsID"]);
                //DataTable dt = ADOHelp.QueryDataTable("exec proc_SearchNewsInfo_ToNewsID " + NewsID + "");
                //Text1.Value = dt.Rows[0]["NewsTitle"].ToString();
               
                //Response.Write("<script language='javascript'>alert('545454545')</script>");
               // TextArea1.Value = dt.Rows[0]["NewsContent"].ToString();
            }
            catch
            {

            }
        }
    }
}
