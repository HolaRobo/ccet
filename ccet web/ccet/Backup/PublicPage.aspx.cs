using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManage
{
    public partial class PublicPage : System.Web.UI.Page
    {
        string UrlPara = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                UrlPara = Request.QueryString["Para"].Trim();
            }
            catch { }
            switch (UrlPara)
            {
                //中心简介
                case "CenterAbstruct":
                    GetCenterAbstruct();
                    break;
                //发展规划
                case "DevelopPlan":
                    GetDevelopPlan();
                    break;
                //学生学习成果
                case "StudentResult":
                    GetStudentResult();
                    break;
                //教师教学成果
                case "TeacherResult":
                    GetTeacherResult();
                    break;

            }
        }
        /// <summary>
        /// 提取中心简介
        /// </summary>
        private void GetCenterAbstruct()
        {
            Label1.Text = "中心简介";
            Label3.Text = ADOHelp.GetSingle(" proc_SearchCenterAbstruct").ToString();
        }

        /// <summary>
        /// 提取发展规划
        /// </summary>
        private void GetDevelopPlan()
        {
            Label1.Text = "机电系实验室建设规划";
            Label3.Text = ADOHelp.GetSingle(" select  top 1 DevelopPlan from dbo.SysSet ").ToString();
        }

        /// <summary>
        /// 学生学习成果
        /// </summary>
        private void GetStudentResult()
        {
            Label1.Text = "学生学习成果";
            Label3.Text = ADOHelp.GetSingle(" select  top 1 StudentResult from dbo.SysSet ").ToString();
        }
        /// <summary>
        /// 教师教学成果
        /// </summary>
        private void GetTeacherResult()
        {
            Label1.Text = "实验教学成果";
            Label3.Text = ADOHelp.GetSingle(" select  top 1 TeacherResult from dbo.SysSet ").ToString();
        }
    }
}
