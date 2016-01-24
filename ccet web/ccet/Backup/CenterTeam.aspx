<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master" AutoEventWireup="true" CodeBehind="CenterTeam.aspx.cs" Inherits="LabManage.CenterTeam" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <style type="text/css">
     table td
     {
     	text-align:center;
     	width:600px;
     }
     table
     {
     	margin:20px auto;
     }
     .td1 span
     {
     	font-size:28px;
     	font-weight:bold;
     }
 </style>
<table>
<tr><td class="td1">
    <asp:Label ID="Label1" runat="server" Text="电子信息实验教学中心专兼职人员名单"></asp:Label></td></tr>
<tr><td class="td2">
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label></td></tr>
</table>
</asp:Content>
