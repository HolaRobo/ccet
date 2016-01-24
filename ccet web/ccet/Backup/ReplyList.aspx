<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master" AutoEventWireup="true" CodeBehind="ReplyList.aspx.cs" Inherits="LabManage.ReplyList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="Stylesheet" href="Style/Style_ReplyList.css" />
   <div class="warp_top">
                留言者/留言内容/回复内容：<asp:TextBox ID="TextBox1" runat="server" CssClass="txtClass"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="查找" CssClass="btnClass2"  onclick="Button1_Click" />
                  &nbsp;&nbsp;<input id="Button_hre" type="button" value="现在去留言" class="btnClass2"   onclick="javascript:location.href='LeaveMessage.aspx'"/>
            </div>
     <div class="reply_warp">
     <div class="reply_title">回复列表</div>
        <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate></HeaderTemplate>
        <ItemTemplate>
        <div class="reply_w">
            <p class="p_Tea"><%#Eval("LeaveManName")%><span><%#Eval("LeaveTime")%></span></p>
            <p class="p_ReplyCon"><%#Eval("LeaveMessageContent")%></p>
            
             <p class="p_admin">管理员<span><%#Eval("ReplyTime")%></span></p>
            <p class="p_adminReply"><%#Eval("ReplyContent")%></p>
        </div>
        </ItemTemplate>
        <FooterTemplate></FooterTemplate>
        </asp:Repeater>
       <webdiyer:AspNetPager ID="AspNetPager1" runat="server" Width="90%" CssClass="paginator"
                            CurrentPageButtonClass="cpb" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList"
                             FirstPageText="首页"  PrevPageText="上一页" NextPageText="下一页" LastPageText="尾页"
                            TextBeforePageIndexBox="转至: " HorizontalAlign="left" PageSize="8" OnPageChanged="AspNetPager1_PageChanged"
                            EnableTheming="true">
        </webdiyer:AspNetPager>
        </div>

</asp:Content>
