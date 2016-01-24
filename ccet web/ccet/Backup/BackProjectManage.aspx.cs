using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace LabManage
{
    public partial class BackProjectManage : System.Web.UI.Page
    {
        string State="";
        string SetUpUser = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                State = Request.QueryString["State"].Trim();
                SetUpUser = Request.QueryString["SetUpUser"].Trim();
            }
            catch { }
            if (!IsPostBack)
            {
               
                SetRepeaterDataSource();
            }
            AspNetPager1.PrevPageText = "上一页";
            AspNetPager1.LastPageText = "尾页";
            AspNetPager1.FirstPageText="首页";
            AspNetPager1.NextPageText = "下一页";
        }
        private void SetRepeaterDataSource()
        {
            AspNetPager1.RecordCount = Convert.ToInt32(ADOHelp.GetSingle("exec proc_BackSearchProjectInfoCount '" + State + "','" + SetUpUser + "'"));

            Repeater1.DataSource = ADOHelp.QueryDataTable("exec proc_BackSearchProjectInfo " + AspNetPager1.PageSize + "," + AspNetPager1.CurrentPageIndex + ",'" + State + "','" + SetUpUser + "'");
            Repeater1.DataBind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            SetRepeaterDataSource();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("BackProjectManage.aspx?State=" + DropDownList1.SelectedItem.Text + "&SetUpUser=" + Text1.Value);
           // Server.Transfer("BackProjectManage.aspx?State=" + DropDownList1.SelectedItem.Text + "&SetUpUser=" + Text1.Value);
        }

        //删除按钮，删除该行，该事件和前台的OnCommand对应
        protected void BtnDown_Click(object sender, CommandEventArgs e)
        {
            //e.Command获取当前这一行数据的id,id在表中为主键
            string FileName = e.CommandName;
            FileName = "UpBookFile/"+FileName;
           string FullFileName = Server.MapPath(FileName);
            //FileName--要下载的文件名 
            FileInfo DownloadFile = new FileInfo(FullFileName);
            if (DownloadFile.Exists)
            {
                Response.Clear();
                Response.ClearHeaders();
                Response.Buffer = false;
                Response.ContentType = "application/octet-stream";
                Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(DownloadFile.FullName, System.Text.Encoding.Default));
                Response.AppendHeader("Content-Length", DownloadFile.Length.ToString());
                Response.WriteFile(DownloadFile.FullName);
                Response.Flush();
                Response.End();
            }
            else
            {
                //文件不存在
            }

        }
    }
}
