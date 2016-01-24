<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master"
    AutoEventWireup="true" CodeBehind="DrviceMaintenanceList.aspx.cs" Inherits="LabManage.DrviceMaintenanceList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="Style/Style_LabManageSystemList.css" />
    <style type="text/css">
        .ul_warp
        {
            margin: 20px;
        }
        .ul_warp li
        {
            height: 30px;
        }
        .ul_warp li a
        {
            font-size: 14px;
        }
      </style>
    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <li><a href='<%#Eval("DrviceMaintenancePath")%>'>
                <%#Eval("DrviceMaintenanceTitle")%></a></li>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
