<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/BackMaster.Master" AutoEventWireup="true"
    CodeBehind="BackUpdAdminPwd.aspx.cs" Inherits="LabManage.BackUpdAdminPwd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="Style/Style_BackAddTeacher.css" />
    <script type="text/javascript" language="javascript" src="Script/Js_BackUpdAdminPwd.js"></script>
    <table border="0" cellspacing="0" class="myTable">
        <tr>
            <td colspan="2" class="td_title" id="td_title">修改我的密码</td>
        </tr>
         <tr>
            <td>旧密码</td>
            <td> <input id="Password1" type="password" /></td>
        </tr>
          <tr>
            <td>新密码</td>
            <td> <input id="Text2" type="password" /></td>
        </tr>
         <tr>
            <td>确认密码</td>
           <td> <input id="Text3" type="password" /></td>
        </tr>
         <tr>
            <td colspan="2" align="center">
                <input id="btnUpd" type="button" value="修改" class="btnOK" /></td>
        </tr>
    </table>
</asp:Content>
