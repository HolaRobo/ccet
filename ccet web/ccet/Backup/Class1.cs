using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace LabManage
{
    public class Class1
    {
        /// <summary>
        /// 用户登录验证
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <param name="Identity"></param>
        /// <returns></returns>
        public static int LoginValidate(string UserName, string UserPwd, string Identity)
        {
            return Convert.ToInt32(ADOHelp.GetSingle("exec proc_LoginValidate '" + UserName + "','" + UserPwd + "','" + Identity + "'"));
        }

        /// <summary>
        /// 给管理员留言
        /// </summary>
        /// <param name="LeaveManName"></param>
        /// <param name="IsTeacher"></param>
        /// <param name="LeaveMessageContent"></param>
        /// <returns></returns>
        public static bool InsertLeaveMessage(string LeaveManName, int IsTeacher, string LeaveMessageContent)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_InsertLeaveMessage '" + LeaveManName + "' ," + IsTeacher + " ,'" + LeaveMessageContent + "' ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 注册时验证教师名称是否存在
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public static bool ValidateTeacherNameExist(string UserName)
        {
            if (ADOHelp.GetSingle("exec ValidateTeacherNameExist " + UserName + "").ToString() != "0")
            {
                return true;//存在
            }
            else
            {
                return false;//不存在
            }
        }
        /// <summary>
        /// 临时方法
        /// </summary>
        /// <param name="CenterframeworkName"></param>
        /// <param name="CenterframeworkContent"></param>
        /// <returns></returns>
        public static bool InsertCenterframeworkData(string CenterframeworkName, string CenterframeworkContent)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_InsertCenterframeworkData '" + CenterframeworkName + "' ,'" + CenterframeworkContent + "' ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 新增实验室制度
        /// </summary>
        /// <param name="LabManageSystemTitle"></param>
        /// <param name="LabManageSystemContent"></param>
        /// <returns></returns>
        public static bool InsertLabManageSystemTitle(string LabManageSystemTitle, string LabManageSystemContent)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_InsertLabManageSystemTitle '" + LabManageSystemTitle + "' ,'" + LabManageSystemContent + "' ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 新增环境安全
        /// </summary>
        /// <param name="LabSafetyTitle"></param>
        /// <param name="LabSafetyContent"></param>
        /// <returns></returns>
        public static bool InsertLabSafetyInfo(string LabSafetyTitle, string LabSafetyContent)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_InsertLabSafetyInfo '" + LabSafetyTitle + "' ,'" + LabSafetyContent + "' ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 验证实验室是否被预约了
        /// </summary>
        /// <param name="LabID"></param>
        /// <param name="Date"></param>
        /// <param name="DateSection"></param>
        /// <returns></returns>
        public static int ValidateLabAppointment(string LabID, string Date, string DateSection)
        {
            return Convert.ToInt32(ADOHelp.GetSingle("exec proc_ValidateLabAppointment '" + LabID + "','" + Date + "','" + DateSection + "'"));
        }
        /// <summary>
        /// 实验室预约
        /// </summary>
        /// <param name="LabID"></param>
        /// <param name="TeacherID"></param>
        /// <param name="TeacherLeaveMessage"></param>
        /// <param name="AppointmentDate"></param>
        /// <param name="DataSection"></param>
        /// <returns></returns>
        public static bool InsertLabAppointment(int LabID, int TeacherID, string TeacherLeaveMessage, string AppointmentDate, string DataSection)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_InsertLabAppointment " + LabID + " ," + TeacherID + " ,'" + TeacherLeaveMessage + "','" + AppointmentDate + "','" + DataSection + "' ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 后台 新增新闻公告
        /// </summary>
        /// <param name="NewsTitle"></param>
        /// <param name="NewsContent"></param>
        /// <param name="Admin"></param>
        /// <returns></returns>
        public static bool InsertNoticeNews(string NewsTitle, string NewsContent, int Admin)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_InsertNoticeNews '" + NewsTitle + "','" + NewsContent + "' ," + Admin + " ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 后台 删除新闻公告
        /// </summary>
        /// <param name="NewsID"></param>
        /// <returns></returns>
        public static bool DeleteNoticeNewsInfo(int NewsID)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_DeleteNoticeNewsInfo " + NewsID + "  ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        ///  后台 修改新闻公告
        /// </summary>
        /// <param name="NewsID"></param>
        /// <param name="NewsTitle"></param>
        /// <param name="NewsContent"></param>
        /// <returns></returns>
        public static bool UpdateNewsInfo(int NewsID, string NewsTitle, string NewsContent)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_UpdateNewsInfo " + NewsID + ",'" + NewsTitle + "','" + NewsContent + "'  ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 提取公告新闻
        /// </summary>
        /// <param name="NewsID"></param>
        /// <returns></returns>
        public static DataTable SearchNewsInfo_ToNewsID(int NewsID)
        {
            return ADOHelp.QueryDataTable("exec proc_SearchNewsInfo_ToNewsID " + NewsID + "");
        }
        /// <summary>
        /// 管理员审批预约
        /// </summary>
        /// <param name="AppointmentID"></param>
        /// <param name="AdminAllow"></param>
        /// <param name="AdminReason"></param>
        /// <returns></returns>
        public static bool AccraditationAppointment(int AppointmentID, int AdminAllow, string AdminReason)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_AccraditationAppointment " + AppointmentID + "," + AdminAllow + ",'" + AdminReason + "'  ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 管理员删除预约
        /// </summary>
        /// <param name="AppointmentID"></param>
        /// <returns></returns>
        public static bool DeleteLabAppointment(int AppointmentID)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_DeleteLabAppointment " + AppointmentID + " ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// /新建或修改教师
        /// </summary>
        /// <param name="TeacherID"></param>
        /// <param name="TeacherName"></param>
        /// <param name="TeacherPwd"></param>
        /// <param name="CreateORUpdate"></param>
        /// <returns></returns>
        public static bool InsertOrUpdateTeacher(int TeacherID, string TeacherName, string TeacherPwd, string CreateORUpdate)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_InsertOrUpdateTeacher " + TeacherID + ",'" + TeacherName + "','" + TeacherPwd + "','" + CreateORUpdate + "' ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 管理员删除教师
        /// </summary>
        /// <param name="AppointmentID"></param>
        /// <returns></returns>
        public static bool DeleteTeacherInfo(int TeacherID)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_DeleteTeacherInfo " + TeacherID + " ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除资源文件
        /// </summary>
        /// <param name="FileID"></param>
        /// <returns></returns>
        public static bool DeleteResourceFile(int FileID)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_DeleteResourceFile " + FileID + " ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 上传资源文件
        /// </summary>
        /// <param name="FileTitle"></param>
        /// <param name="FileTypeName"></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public static bool InsertResourceFile(string FileTitle, string FileTypeName, string FileName)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_InsertResourceFile  '" + FileTitle + "','" + FileTypeName + "','" + FileName + "' ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 提起公共数据
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static DataTable SearchPublicInfo(string command)
        {
            return ADOHelp.QueryDataTable("exec proc_SearchPublicInfo '" + command + "'");
        }


        /// <summary>
        /// 更新公共信息
        /// </summary>
        /// <param name="command"></param>
        /// <param name="Content"></param>
        /// <returns></returns>
        public static bool UpdatePublicInfo(string command, string Content)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_UpdatePublicInfo  '" + command + "','" + Content + "' ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除制度或安全
        /// </summary>
        /// <param name="command"></param>
        /// <param name="MyID"></param>
        /// <returns></returns>
        public static bool DeleteSystemAndSafety(string command, int MyID)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_DeleteSystemAndSafety  '" + command + "'," + MyID + " ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 提取制度或安全的内容
        /// </summary>
        /// <param name="command"></param>
        /// <param name="myid"></param>
        /// <returns></returns>
        public static DataTable SearchSystemAndSafetyContent(string command, int myid)
        {
            return ADOHelp.QueryDataTable("exec proc_SearchSystemAndSafetyContent '" + command + "'," + myid + "");
        }

        /// <summary>
        /// 新增或修改制度或安全
        /// </summary>
        /// <param name="CreORUpd"></param>
        /// <param name="command"></param>
        /// <param name="MyID"></param>
        /// <param name="Title"></param>
        /// <param name="Content"></param>
        /// <returns></returns>
        public static bool UpdateSystemAndSafety(string CreORUpd, string command, int MyID, string Title, string Content)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_UpdateSystemAndSafety  '" + CreORUpd + "','" + command + "'," + MyID + ",'" + Title + "','" + Content + "' ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="DrviceMaintenanceID"></param>
        /// <returns></returns>
        public static bool DeleteDrviceMaintenance(int DrviceMaintenanceID)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_DeleteDrviceMaintenance " + DrviceMaintenanceID + " ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool InsertDrviceMaintenance(string DrviceMaintenanceTitle, string DrviceMaintenancePath)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_InsertDrviceMaintenance '" + DrviceMaintenanceTitle + "','" + DrviceMaintenancePath + "'") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 后台删除留言
        /// </summary>
        /// <param name="LeaveMessageID"></param>
        /// <returns></returns>
        public static bool DeleteLeaveMessage(int LeaveMessageID)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_DeleteLeaveMessage  " + LeaveMessageID + " ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
         /// <summary>
         /// 管理员回复留言
         /// </summary>
         /// <param name="LeaveMessageID"></param>
         /// <param name="ReplyContent"></param>
         /// <returns></returns>
        public static bool UpdateLeaveMessage(int LeaveMessageID,string ReplyContent)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_UpdateLeaveMessage  " + LeaveMessageID + " ,'" + ReplyContent + "'") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// 后台新增修改和删除实验室
        /// </summary>
        /// <param name="CUD"></param>
        /// <param name="LabID"></param>
        /// <param name="LabName"></param>
        /// <param name="LabTypeID"></param>
        /// <param name="MaxNO"></param>
        /// <returns></returns>
        public static bool BackCUDLabInfo(string CUD, int LabID, string LabName, int LabTypeID, int MaxNO)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_BackCUDLabInfo  '" + CUD + "'," + LabID + " ,'" + LabName + "' ," + LabTypeID + " ," + MaxNO + " ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       /// <summary>
       /// 添加、修改或删除实验室类型
       /// </summary>
       /// <param name="LabTypeID"></param>
       /// <param name="LabTypeName"></param>
       /// <param name="Command"></param>
       /// <returns></returns>
        public static bool BackOpearLabType( int LabTypeID, string LabTypeName, string Command)
        {
            if (ADOHelp.ExecuteSql_ReturnRow("exec proc_BackOpearLabType  " + LabTypeID + ",'" + LabTypeName + "' ,'" + Command + "' ") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
