<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master" AutoEventWireup="true" CodeBehind="DemonstrationCenterList.aspx.cs" Inherits="LabManage.DemonstrationCenterList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="Style/Style_NewsInfoList.css" />
    <div  class="top">
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server"  Width="90%" CssClass="paginator"
            CurrentPageButtonClass="cpb" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList"
            UrlPaging="true" TextBeforePageIndexBox="转至: " HorizontalAlign="left" PageSize="20"
            EnableTheming="true" OnPageChanged="AspNetPager1_PageChanged" >
        </webdiyer:AspNetPager>
    </div>
    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <table border="0" class="classTable" cellpadding="0" cellspacing="0">
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td class="td_1"><a href='<%#"DemonstrationCenterDetail.aspx?DCID="+Eval("DCID")%>'> <%#Eval("DCTitle")%></a>
                </td>
                <td class="td_2"><%#Eval("PublicTime")%>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

