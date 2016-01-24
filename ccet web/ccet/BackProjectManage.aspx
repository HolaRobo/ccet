<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master"
    AutoEventWireup="true" CodeBehind="BackProjectManage.aspx.cs" Inherits="LabManage.BackProjectManage" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="Style/Style_BackProjectManage.css" />

    <script type="text/javascript" language="javascript" src="Script/Js_BackProjectManage.js"></script>
    <div class="backProject_top">
     项目状态：<asp:DropDownList ID="DropDownList1" runat="server">
     <asp:ListItem>立项待审</asp:ListItem>
     <asp:ListItem>已审待结</asp:ListItem>
     <asp:ListItem>已申请结题</asp:ListItem>
     <asp:ListItem>成功结题</asp:ListItem>
        </asp:DropDownList>
        申报人：<input id="Text1"  class="classText1" type="text"  runat="server"/><asp:Button ID="Button1" runat="server"  CssClass="btnSearch"
            Text="查找" onclick="Button1_Click" /></div>
 <div class="webdiyer">
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" Width="90%" CssClass="paginator"
            CurrentPageButtonClass="cpb" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList"
            UrlPaging="true" TextBeforePageIndexBox="转至: " HorizontalAlign="left" PageSize="6"
            EnableTheming="true" onpagechanged="AspNetPager1_PageChanged">
        </webdiyer:AspNetPager>
    </div>
    <asp:Repeater ID="Repeater1" runat="server" >
        <HeaderTemplate>
            <table class="myProTable" border="0" cellspacing="0" cellpadding="0" id="idTable">
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td class="td_title">项目名称</td><td class="td_title" colspan="15" style="color:#3DB1FF"><%#Eval("ProjectName")%></td>
            </tr>
            <tr><td colspan="16" class="td_title2">项目基本信息</td></tr>
            <tr>
             <td class="td_bg td_span">项目来源单位</td><td><%#Eval("ProjectFrom")%></td>
                <td class="td_bg td_span">项目性质</td><td><%#Eval("ProjectType")%></td>
                <td class="td_bg td_span">立项日期</td><td><%#Eval("SetUpDate")%></td>
                <td class="td_bg td_span">结题日期</td><td><%#Eval("CompleteDate")%></td>
                <td class="td_bg td_span">经费(万元)</td><td style="color:#C24E00; font-weight:bold"><%#Eval("Funds")%></td>
                <td class="td_bg td_span">成果形式</td><td colspan="3"><%#Eval("ProjectResultType")%></td>
               </tr>
               <tr ><td colspan="16" class="td_title2">项目进展</td></tr>
               <tr>
                 <td class="td_bg">审核状态</td><td style="color:#CC0033;font-weight:bold"><%#Eval("State")%></td>
                 <td class="td_bg">审批专家</td><td><%#Eval("AuditUserName")%></td>
                 <td class="td_bg">审批日期</td><td><%#Eval("AuditDate")%></td>
                 <td class="td_bg">审批结果</td><td style="color:Red"><%#Eval("IsAgree_AuditResult")%></td>
                <tr>
                 <td class="td_bg">申请结题日期</td><td><%#Eval("CompleteApplyDate")%></td>
                 <td class="td_bg">评审专家</td><td><%#Eval("CompleteUserName")%></td>
                 <td class="td_bg">评审日期</td><td><%#Eval("IsAgree_CompleteApply_date")%></td>
                 <td class="td_bg">评审结果</td><td style="color:Red"><%#Eval("IsAgree_CompleteApply")%></td>
                 <td>
                     <asp:Button ID="Button2" runat="server" Text="下载申报书"  CssClass="btnApplyCom" 
                     CommandName=<%#Eval("DeclarationBookName") %> OnCommand="BtnDown_Click"/></td>
                     <td>
                     <input id=<%#Eval("ProjectID")%> type="button" value="删除" class="btnDelete"/></td>
             </tr>
           <tr><td></td></tr>
        </ItemTemplate>
        <FooterTemplate>
            </table></FooterTemplate>
    </asp:Repeater>
   
</asp:Content>
