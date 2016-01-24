using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManage
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {/*
            if (!IsPostBack)
            {
                //新闻公告
                Repeater1.DataSource = ADOHelp.QueryDataTable("exec proc_SearchNewsInfoList");
                Repeater1.DataBind();
                //管理规定
                Repeater2.DataSource = ADOHelp.QueryDataTable("SELECT Top 5 LabManageSystemID,LabManageSystemTitle FROM LabManageSystem");
                Repeater2.DataBind();
                //资源下载列表
                Repeater3.DataSource = ADOHelp.QueryDataTable(@"SELECT Top 5 [FileID],[FileTitle],[FileTypeName]
                                          ,'../ResourceFile/'+RTRIM(FileName) as FileName
                                      FROM [ResourceFile]");
                Repeater3.DataBind();

                //示范中心
                Repeater4.DataSource = ADOHelp.QueryDataTable(@"SELECT Top 5 * FROM [DemonstrationCenter]");
                Repeater4.DataBind();
            }*/
        }
    }
}
