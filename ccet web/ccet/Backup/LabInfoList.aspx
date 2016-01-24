<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master"
    AutoEventWireup="true" CodeBehind="LabInfoList.aspx.cs" Inherits="LabManage.LabInfoList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript" language="javascript" src="Script/Js_LabInfoList.js"></script>

    <link rel="stylesheet" type="text/css" href="Style/Style_LabInfoList.css" />
    <div class="LabInfoList_top">
        实验室类型：<asp:DropDownList ID="DropDownList1" runat="server" CssClass="SelectLabType">
        </asp:DropDownList>
        容纳人数不低于：<input id="txtMaxNO" type="text" class="txtMaxNO" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="确定" CssClass="btnOK" OnClick="Button1_Click" />
    </div>
    <div class="LabInfoList_center">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                        <table border="0" cellpadding="0" cellspacing="0" id="idMyTable">
                        <tr>
                         <th class="nobg">实验室名</th>
                          <th>类型</th>
                           <th>最多容纳人数</th>
                            <th>预约</th>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                              <td class="spec"><%#Eval("LabName") %></td>
                             <td><%#Eval("LabTypeName")%></td>
                              <td><%#Eval("MaxNO")%></td>
                              <td><input type="button" value="预约" onclick="javascript:window.location.href='LabAppointment.aspx?LabID=<%#Eval("LabID")%>&LabName=<%#Eval("LabName")%>'" class="btnLabInfoList" /></td>
                        </tr>
                    </ItemTemplate>
   
                    <FooterTemplate>
                        </table></FooterTemplate>
                </asp:Repeater>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
