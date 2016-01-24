<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master" AutoEventWireup="true" CodeBehind="LabManageSystemList.aspx.cs" Inherits="LabManage.LabManageSystemList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="Style/Style_LabManageSystemList.css" />
  
        <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
          <ul class="ul_warp">
        </HeaderTemplate>
        <ItemTemplate>
        <li><a href='<%#"LabManageSystem.aspx?LabManageSystemID="+Eval("LabManageSystemID")%>'> <%#Eval("LabManageSystemTitle")%></a></li>
        </ItemTemplate>
        <FooterTemplate>
         </ul>
        </FooterTemplate>
        
        </asp:Repeater>
   
</asp:Content>
