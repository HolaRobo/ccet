<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master" AutoEventWireup="true" CodeBehind="LabSafetyInfo.aspx.cs" Inherits="LabManage.LabSafetyInfo" %>
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
     tr
     {
     	height:70px;
     }
     .td1 span
     {
     	font-size:28px;
     	font-weight:bold;
     }
 </style>
<table>
<tr><td class="td1">
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td></tr>
<tr><td class="td2" style="font-size:14px">
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label></td></tr>
</table>
</asp:Content>
