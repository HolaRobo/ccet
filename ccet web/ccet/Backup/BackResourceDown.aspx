<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/BackMaster.Master"
    AutoEventWireup="true" CodeBehind="BackResourceDown.aspx.cs" Inherits="LabManage.BackResourceDown" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript" src="../uploadify/swfobject.js"></script>

    <script type="text/javascript" src="../uploadify/jquery.uploadify.v2.1.0.min.js"></script>
   
   <script type="text/javascript" src="Script/Js_BackResourceDown.js"></script>
    <link rel="stylesheet" type="text/css" href="Style/Style_BackResourceDown.css" />
    <div class="BackResourceDown_Content">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
      <asp:Repeater ID="Repeater1" runat="server">
          <HeaderTemplate>
              <table border="0" cellpadding="0" cellspacing="0" id="idMyTable">
                  <tr>
                        <th class="th_1">资源名称</th>
                        <th class="th_2">资源类型</th>
                        <th class="th_3">下载</th>
                        <th class="th_4">删除</th>
                      </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                             <td class="td_1" valign="middle"><%#Eval("FileTitle")%></td>
                             <td class="td_2" valign="middle"><%#Eval("FileTypeName")%></td>
                             <td class="td_3" valign="bottom"><a href='<%#Eval("FileName")%>'>下载</a></td>
                             <td class="td_4" valign="bottom"><input id=<%#Eval("FileID")%> type="button" value="删除"  class="btnDel btnclass"/></td>
                                 
                        </tr>
                    </ItemTemplate>
   
                    <FooterTemplate>
                        </table></FooterTemplate>
                </asp:Repeater>
                  </ContentTemplate>
        </asp:UpdatePanel>
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="paginator"
                        CurrentPageButtonClass="cpb" ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" 
                        TextBeforePageIndexBox="转至: " HorizontalAlign="left" PageSize="6"  
                        EnableTheming="true" onpagechanged="AspNetPager1_PageChanged" >
                    </webdiyer:AspNetPager>
    </div>
    <div class="BackResourceDown_bottom">
    资源名称<input id="Text1" type="text"  class="txtResourceTitle"/>
      资源类型&nbsp;<select id="Select1">
            <option>表格资源</option>
              <option>课件资源</option>
                <option>大纲资源</option>
                  <option>实验教材</option>
        </select>
        <div class="div_btn">
        <input id="Text2" type="text" class="txtPath"  readonly="readonly"/><input id="btnFile" type="button" value="button" class="btnFile"/> 
        <input id="btnSave" type="button" value="保存"  class="btnSave"/>
        </div>
    </div>
</asp:Content>
