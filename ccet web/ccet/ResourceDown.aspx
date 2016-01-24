<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master"
    AutoEventWireup="true" CodeBehind="ResourceDown.aspx.cs" Inherits="LabManage.ResourceDown" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="Style/Style_ResourceDown.css" />

    <script type="text/javascript" language="javascript" src="Script/Js_ResourceDown.js"></script>

    <div>
        <select id="Select1" runat="server">
            <option>表格资源</option>
            <option>课件资源</option>
            <option>大纲资源</option>
            <option>实验教材</option>
        </select>
        <asp:Button ID="Button3" runat="server" Text="提取" onclick="Button3_Click" CssClass="btnSearch" /></div>
    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <table border="0" class="classTable" cellpadding="0" cellspacing="0">
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td class="td_2"><%#Eval("FileTypeName")%></td>
                <td class="td_1"><a href='<%#Eval("FileName")%>'><%#Eval("FileTitle")%></a>
                </td>
                <td class="td_3">
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
