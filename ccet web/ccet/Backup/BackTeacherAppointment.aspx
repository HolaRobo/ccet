<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/BackMaster.Master"
    AutoEventWireup="true" CodeBehind="BackTeacherAppointment.aspx.cs" Inherits="LabManage.BackTeacherAppointment" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

    <link rel="stylesheet" type="text/css" href="Style/Style_BackTeacherAppointment.css" />
      <div class="BackTeacherAppointment_top">
         <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="paginator"
                        CurrentPageButtonClass="cpb" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" 
                        TextBeforePageIndexBox="转至: " HorizontalAlign="left" PageSize="12"  
                        EnableTheming="true" onpagechanged="AspNetPager1_PageChanged" >
                    </webdiyer:AspNetPager>
    </div>
    <div class="BackTeacherAppointment_center">
      <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                        <table border="0" cellpadding="0" cellspacing="0" id="idMyTable">
                        <tr>
                         <th class="nobg">教师名称</th>
                          <th>实验室</th>
                           <th>类型</th>
                            <th class="th_time">预约时间</th>
                              <th  >预约留言</th>
                              <th>批准否</th>
                              <th >管理员留言</th>
                              <th>操作</th>
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
                                   <td><input type="button" value="操作"  onclick="window.location.href='BackaccraditationLabApp.aspx?AppointmentID=<%#Eval("AppointmentID")%> '" class="btnclass" /></td>
                        </tr>
                    </ItemTemplate>
   
                    <FooterTemplate>
                        </table></FooterTemplate>
                </asp:Repeater>
    </div>
</asp:Content>
