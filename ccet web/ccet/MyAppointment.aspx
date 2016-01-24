<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master"
    AutoEventWireup="true" CodeBehind="MyAppointment.aspx.cs" Inherits="LabManage.MyAppointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript" language="javascript" src="Script/Js_MyAppointment.js"></script>
        <script language="javascript">
            $(function() {
            $("#idMyTable td").each(function() {
                if ($(this).text() == "批准") {
                    $(this).css({ "color": "Green" })
                }
                if ($(this).text() == "不批准") {
                    $(this).css({ "color": "Red" })
                }
            })
            })
        </script>
    <link rel="stylesheet" type="text/css" href="Style/Style_MyAppointment.css" />
    <div class="top">一周内预约情况 <input id="Button1" type="button" value="现在预约"  class="btnClass3" onclick="window.location.href='LabInfoList.aspx'"/></div>
    <div class="MyAppointment_center">
      <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                        <table border="0" cellpadding="0" cellspacing="0" id="idMyTable">
                        <tr>
                         <th class="nobg">教师名称</th>
                          <th>实验室</th>
                           <th>类型</th>
                            <th>预约时间</th>
                              <th  style=" width:200px">预约留言</th>
                              <th>批准否</th>
                              <th style=" width:200px">管理员留言</th>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                              <td class="spec"><%#Eval("TeacherName")%></td>
                             <td><%#Eval("LabName")%></td>
                              <td><%#Eval("LabTypeName")%></td>
                                <td><%#Eval("AppointmentDate")%></td>
                                <td><%#Eval("TeacherLeaveMessage")%></td>
                                 <td><%#Eval("AdminAllow")%></td>
                                  <td><%#Eval("AdminReason")%></td>
                        </tr>
                    </ItemTemplate>
   
                    <FooterTemplate>
                        </table></FooterTemplate>
                </asp:Repeater>
    </div>
</asp:Content>
