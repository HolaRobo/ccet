<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master" AutoEventWireup="true" CodeBehind="PublicPage.aspx.cs" Inherits="LabManage.PublicPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <style type="text/css">
     
     table td
     {
     	text-align:center;
     }
     table
     {
     	margin:10px auto;
     }
     .td2 span
     {
     	font-size:28px;
     	font-weight:bold;
     	
     }
 </style>
    <table width="800px" border="0">
  <tr>
    <td class="td1"></td>
  </tr>
  <tr>
    <td class="td2">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
  </tr>
  <tr>
    <td class="td3">
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
  </tr>
  <tr>
    <td class="td5">
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>
  </tr>

</table>
</asp:Content>
