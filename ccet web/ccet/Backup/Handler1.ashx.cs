using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

using System.Web.SessionState;
using System.IO;
using System.Text;
namespace LabManage
{




    /*Request.Params["id"]、Request.Form["id"]和Request.QueryString["id"]的用法以及区别?
       Request.Params是所有post和get传过来的值的集合,Request.Form是取post传值, Request.QueryString是get传过来的值*/
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class Handler1 : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int UserID = 0;
            string userName, userPwd, Identity;
            string str = context.Request.QueryString["Action"].ToString().Trim();
            switch (str)
            {

                //登录验证请求
                case "LoginValidate":
                    userName = context.Request.QueryString["UserName"].ToString().Trim();
                    userPwd = context.Request.QueryString["UserPwd"].ToString().Trim();
                    Identity = context.Request.QueryString["Identity"].ToString().Trim(); ;
                    //登录验证 返回用户ID
                    UserID = Class1.LoginValidate(userName, userPwd, Identity);
                    if (UserID > 0)
                    {
                        //保存登录名
                        context.Response.Cookies.Add(new HttpCookie("CookieUserID", HttpUtility.UrlEncode(UserID.ToString())));
                        context.Response.Cookies.Add(new HttpCookie("CookieUserName", HttpUtility.UrlEncode(userName)));
                        context.Response.Cookies.Add(new HttpCookie("CookieIdentity", Identity));
                        context.Response.Write("1");


                    }
                    else
                    {
                        //验证失败
                        context.Response.Write("0");
                    }
                    break;
                //验证教师名称是否存在
                case "ValidateTeacherNameExist":

                    userName = context.Request.QueryString["UserName"].ToString().Trim();
                    if (Class1.ValidateTeacherNameExist(userName) == true)
                    {
                        context.Response.Write("1");//存在
                    }
                    else
                    {
                        context.Response.Write("0");//不存在
                    }
                    break;

                //新增中心机构
                case "InsertCenterframeworkData":

                    string CenterframeworkName = context.Request.QueryString["CenterframeworkName"].ToString().Trim();
                    string CenterframeworkContent = context.Request.QueryString["CenterframeworkContent"].ToString().Trim();
                    if (Class1.InsertCenterframeworkData(CenterframeworkName, CenterframeworkContent) == true)
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;

                //新增实验室管理制度
                case "InsertLabManageSystemTitle":

                    string LabManageSystemTitle = context.Request.QueryString["LabManageSystemTitle"].ToString().Trim();
                    string LabManageSystemContent = context.Request.QueryString["LabManageSystemContent"].ToString().Trim();
                    if (Class1.InsertLabManageSystemTitle(LabManageSystemTitle, LabManageSystemContent) == true)
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;


                //新增实验环境安全说明
                case "InsertLabSafetyInfo":

                    string LabSafetyTitle = context.Request.QueryString["LabSafetyTitle"].ToString().Trim();

                    string LabSafetyContent = context.Request.QueryString["LabSafetyContent"].ToString().Trim();
                    if (Class1.InsertLabSafetyInfo(LabSafetyTitle, LabSafetyContent) == true)
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;

                //给管理员留言
                case "InsertLeaveMessage":

                    string LeaveManName = context.Request.QueryString["LeaveManName"].ToString().Trim();
                    int IsTeacher = Convert.ToInt32(context.Request.QueryString["IsTeacher"]);
                    string LeaveMessageContent = context.Request.QueryString["LeaveMessageContent"].ToString().Trim();
                    if (Class1.InsertLeaveMessage(LeaveManName, IsTeacher, LeaveMessageContent) == true)
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //验证实验室是否已被预约
                case "ValidateLabAppointment":

                    string LabID = context.Request.QueryString["LabID"].ToString().Trim();
                    string Date = context.Request.QueryString["Date"].ToString().Trim();
                    string DateSection = context.Request.QueryString["DateSection"].ToString().Trim();

                    if (Class1.ValidateLabAppointment(LabID, Date, DateSection) == 0)
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;

                //实验室预约
                case "InsertLabAppointment":

                    int LabID_1 = Convert.ToInt32(context.Request.QueryString["LabID"]);
                    UserID = Convert.ToInt32(context.Request.QueryString["TeacherID"]); //登录教师ID
                    string TeacherLeaveMessage = context.Request.QueryString["TeacherLeaveMessage"].ToString().Trim();
                    string Date_ = context.Request.QueryString["Date"].ToString().Trim();

                    string DateSection_1 = context.Request.QueryString["DateSection"].ToString().Trim();

                    if (Class1.InsertLabAppointment(LabID_1, UserID, TeacherLeaveMessage, Date_, DateSection_1))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //管理员回复留言
                case "UpdateLeaveMessage":

                    int LeaveID = Convert.ToInt32(context.Request.QueryString["LeaveID"]);
                    string ReplyContent = context.Request.QueryString["ReplyContent"].ToString().Trim();
                    if (Class1.UpdateLeaveMessage(LeaveID, ReplyContent) == true)
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //新增新闻公告
                case "InsertNoticeNews":
                    int AdminID_1 = Convert.ToInt32(context.Request.QueryString["AdminID"]);
                    string NewsTitle_1 = context.Request.QueryString["NewsTitle"].ToString().Trim();
                    string NewsContent_1 = context.Request.QueryString["NewsContent"].ToString().Trim();
                    if (Class1.InsertNoticeNews(NewsTitle_1, NewsContent_1, AdminID_1))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //删除新闻公告
                case "DeleteNoticeNewsInfo":

                    int NewsID = Convert.ToInt32(context.Request.QueryString["NewsID"]); //
                    if (Class1.DeleteNoticeNewsInfo(NewsID))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //修改新闻公告
                case "UpdateNewsInfo":

                    int NewsID_1 = Convert.ToInt32(context.Request.QueryString["NewsID"]);
                    string NewsTitle = context.Request.QueryString["NewsTitle"].ToString().Trim();
                    string NewsContent = context.Request.QueryString["NewsContent"].ToString().Trim();

                    if (Class1.UpdateNewsInfo(NewsID_1, NewsTitle, NewsContent))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //
                case "SearchNewsInfo":
                    context.Response.ContentType = "join/plain";
                    int NewsID_2 = Convert.ToInt32(context.Request.QueryString["NewsID"]);
                    DataTable dt = Class1.SearchNewsInfo_ToNewsID(NewsID_2);
                    // context.Response.Write({"str1":dt.Rows[0]["NewsTitle"],"str2":dt.Rows[0]["NewsContent"]});
                    context.Response.Write(dt.Rows[0]["NewsContent"]);
                    // context.Response.Write("{'str1':'" + dt.Rows[0]["NewsTitle"] + "'}");
                    // context.Response.Write("{'city':'Beijing','street':' Chaoyang Road'}");
                    break;

                //管理员审批预约
                case "AccraditationAppointment":

                    int AppointmentID = Convert.ToInt32(context.Request.QueryString["AppointmentID"]);
                    int AdminAllow = Convert.ToInt32(context.Request.QueryString["AdminAllow"]);
                    string AdminReason = context.Request.QueryString["AdminReason"].ToString().Trim();

                    if (Class1.AccraditationAppointment(AppointmentID, AdminAllow, AdminReason))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //管理员删除预约
                case "DeleteLabAppointment":

                    int AppointmentID_1 = Convert.ToInt32(context.Request.QueryString["AppointmentID"]);
                    if (Class1.DeleteLabAppointment(AppointmentID_1))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;

                //新增或修改
                case "InsertOrUpdateTeacher":

                    int TeacherID = Convert.ToInt32(context.Request.QueryString["TeacherID"]);
                    string TeacherName = context.Request.QueryString["TeacherName"].ToString().Trim();
                    string TeacherPwd = context.Request.QueryString["TeacherPwd"].ToString().Trim();
                    string CreateORUpdate = context.Request.QueryString["CreateORUpdate"].ToString().Trim();
                    if (Class1.InsertOrUpdateTeacher(TeacherID, TeacherName, TeacherPwd, CreateORUpdate))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //管理员删除教师
                case "DeleteTeacherInfo":

                    int TeacherID_1 = Convert.ToInt32(context.Request.QueryString["TeacherID"]);
                    if (Class1.DeleteTeacherInfo(TeacherID_1))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //管理员删除下载资源
                case "DeleteResourceFile":

                    int FileID = Convert.ToInt32(context.Request.QueryString["FileID"]);
                    if (Class1.DeleteResourceFile(FileID))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;


                ////上传资源文件
                case "InsertResourceFile":
                    //  string filetitle = context.Request.Params["FileTitle"].ToString().Trim();
                    HttpPostedFile postedFile1 = context.Request.Files["Filedata"];
                    string savepath1 = "";
                    string tempPath1 = "";
                    tempPath1 = "~/ResourceFile/";
                    savepath1 = context.Server.MapPath(tempPath1);//获取根目录
                    string filename1 = postedFile1.FileName;
                    string sExtension1 = filename1.Substring(filename1.LastIndexOf('.'));//扩展名
                    string sNewFileName = "";//文件名
                    if (postedFile1 != null)
                    {
                        if (!Directory.Exists(savepath1))
                        {
                            Directory.CreateDirectory(savepath1);
                        }
                        sNewFileName = DateTime.Now.ToString("yyyyMMddhhmmsfff");
                        postedFile1.SaveAs(savepath1 + @"\" + sNewFileName + sExtension1);
                    }

                    string FileTitle = context.Request.Params["FileTitle"].ToString().Trim();
                    string FileTypeName = context.Request.Params["FileTypeName"].ToString().Trim();
                    string DeclarationBookName = sNewFileName + sExtension1;//文件名+扩展名
                    if (Class1.InsertResourceFile(FileTitle, FileTypeName, DeclarationBookName) == true)
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //提取公共信息
                case "SearchPublicInfo":
                    string Command = context.Request.QueryString["Command"];
                    context.Response.Write(Class1.SearchPublicInfo(Command).Rows[0]["ContentInfo"]);
                    break;
                //更新公共信息
                case "UpdatePublicInfo":
                    string Command_1 = context.Request.QueryString["Command"].Trim();
                    string Content = context.Request.QueryString["Content"].Trim();
                    if (Class1.UpdatePublicInfo(Command_1, Content))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //删除制度或安全
                case "DeleteSystemAndSafety":
                    string Command_2 = context.Request.QueryString["Command"].Trim();
                    int myid = Convert.ToInt32(context.Request.QueryString["MyID"].Trim());
                    if (Class1.DeleteSystemAndSafety(Command_2, myid))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //提取制度或安全内容
                case "SearchSystemAndSafetyContent":
                    string Command_3 = context.Request.QueryString["Command"];
                    int myid_1 = Convert.ToInt32(context.Request.QueryString["MyID"].Trim());
                    context.Response.Write(Class1.SearchSystemAndSafetyContent(Command_3, myid_1).Rows[0]["contentInfo"]);
                    break;
                //新增或修改制度或安全
                case "UpdateSystemAndSafety":
                    string CreORUpd = context.Request.QueryString["CreORUpd"].Trim();
                    string command_4 = context.Request.QueryString["Command"].Trim();
                    int myid_2 = Convert.ToInt32(context.Request.QueryString["MyID"].Trim());
                    string Title = context.Request.QueryString["Title"].Trim();
                    string Content_1 = context.Request.QueryString["Content"].Trim();
                    if (Class1.UpdateSystemAndSafety(CreORUpd, command_4, myid_2, Title, Content_1))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;

                case "DeleteDrviceMaintenance":
                    int DrviceMaintenanceID = Convert.ToInt32(context.Request.QueryString["DrviceMaintenanceID"].Trim());
                    if (Class1.DeleteDrviceMaintenance(DrviceMaintenanceID))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;

                case "InsertDrviceMaintenance":
                    //  string filetitle = context.Request.Params["FileTitle"].ToString().Trim();
                    HttpPostedFile postedFile1_1 = context.Request.Files["Filedata"];
                    string savepath1_1 = "";
                    string tempPath1_1 = "";
                    tempPath1_1 = "~/ResourceFile/";
                    savepath1_1 = context.Server.MapPath(tempPath1_1);//获取根目录
                    string filename1_1 = postedFile1_1.FileName;
                    string sExtension1_1 = filename1_1.Substring(filename1_1.LastIndexOf('.'));//扩展名
                    string sNewFileName_1 = "";//文件名
                    if (postedFile1_1 != null)
                    {
                        if (!Directory.Exists(savepath1_1))
                        {
                            Directory.CreateDirectory(savepath1_1);
                        }
                        sNewFileName_1 = DateTime.Now.ToString("yyyyMMddhhmmsfff");
                        postedFile1_1.SaveAs(savepath1_1 + @"\" + sNewFileName_1 + sExtension1_1);
                    }

                    string DrviceMaintenanceTitle = context.Request.Params["DrviceMaintenanceTitle"].ToString().Trim();
                    string DrviceMaintenancePath = sNewFileName_1 + sExtension1_1;//文件名+扩展名
                    if (Class1.InsertDrviceMaintenance(DrviceMaintenanceTitle, DrviceMaintenancePath) == true)
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //删除留言
                case "DeleteLeaveMessage":
                    int LeaveMessageID = Convert.ToInt32(context.Request.QueryString["LeaveMessageID"].Trim());
                    if (Class1.DeleteLeaveMessage(LeaveMessageID))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //后台新增修改和删除实验室
                case "BackCUDLabInfo":
                    string CUD = context.Request.QueryString["CUD"].Trim();
                    int LabID_2 = Convert.ToInt32(context.Request.QueryString["LabID"].Trim());
                    string LabName = context.Request.QueryString["LabName"].Trim();

                    int LabTypeID = Convert.ToInt32(context.Request.QueryString["LabTypeID"].Trim());
                    int MaxNO = Convert.ToInt32(context.Request.QueryString["MaxNO"].Trim());
                    if (Class1.BackCUDLabInfo(CUD, LabID_2, LabName, LabTypeID, MaxNO))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //添加、修改或删除实验室类型
                case "BackOpearLabType":
                    int LabTypeID_1 = Convert.ToInt32(context.Request.QueryString["LabTypeID"].Trim());
                    string LabTypeName = context.Request.QueryString["LabTypeName"].Trim();
                    string Command_0 = context.Request.QueryString["Command"].Trim();

                    if (Class1.BackOpearLabType(LabTypeID_1, LabTypeName, Command_0))
                    {
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }
                    break;
                //教师或管理员修改密码
                case "UpdateTeacherAdminPwd":
                    userName = context.Request.QueryString["TeacherName"].Trim();
                    userPwd = context.Request.QueryString["OldPwd"].Trim();
                    string userPwd_New = context.Request.QueryString["NewPwd"].Trim();
                    Identity = context.Request.QueryString["Identity"].Trim();
                    int RetutnValue = 0;
                    ADOHelp.ExecUpdateTeacherPwd(userName, userPwd, userPwd_New,Identity, out RetutnValue);
                    context.Response.Write(RetutnValue);
                    break;
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
