<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/BackMaster.Master" AutoEventWireup="true" CodeBehind="BackDrviceMaintenance.aspx.cs" Inherits="LabManage.BackDrviceMaintenance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript" src="../uploadify/swfobject.js"></script>

    <script type="text/javascript" src="../uploadify/jquery.uploadify.v2.1.0.min.js"></script>
   
   <script type="text/javascript" src="Script/Js_BackDrviceMaintenance.js"></script>
    <link rel="stylesheet" type="text/css" href="Style/Style_BackDrviceMaintenance.css" />
    <div class="BackDrviceMaintenance_Content">
 <asp:Repeater ID="Repeater1" runat="server">
          <HeaderTemplate>
              <table border="0" cellpadding="0" cellspacing="0" id="idMyTable">
                  <tr>
                        <th class="th_1">设备运行与维护</th>
                        <th class="th_3">下载</th>
                        <th class="th_4">删除</th>
                      </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                             <td class="td_1" valign="middle"><%#Eval("DrviceMaintenanceTitle")%></td>
                             <td class="td_3" valign="bottom"><a href='<%#Eval("DrviceMaintenancePath")%>'>下载</a></td>
                             <td class="td_4" valign="bottom"><input id=<%#Eval("DrviceMaintenanceID")%> type="button" value="删除"  class="btnDel btnclass"/></td>
                                 
                        </tr>
                    </ItemTemplate>
   
                    <FooterTemplate>
                        </table></FooterTemplate>
                </asp:Repeater>
     
    </div>
    <div class="BackDrviceMaintenance_bottom">
    题目<input id="Text1" type="text"  class="txtResourceTitle"/>
        <div class="div_btn">
        <input id="Text2" type="text" class="txtPath"  readonly="readonly"/><input id="btnFile" type="button" value="button" class="btnFile"/> 
        <input id="btnSave" type="button" value="保存"  class="btnSave"/>
        </div>
    </div>
</asp:Content>

