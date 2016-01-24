<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/BackMaster.Master" AutoEventWireup="true"
    CodeBehind="BackAddTeacher.aspx.cs" Inherits="LabManage.BackAddTeacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="Style/Style_BackAddTeacher.css" />
    <script type="text/javascript" language="javascript" src="Script/Js_BackAddTeacher.js"></script>
    <table border="0" cellspacing="0" class="myTable">
        <tr>
            <td colspan="2" class="td_title" id="td_title">新增教师用户</td>
        </tr>
          <tr>
            <td>教师登录名</td>
            <td> <input id="Text1" type="text" /></td>
        </tr>
          <tr>
            <td>密码</td>
            <td> <input id="Text2" type="password" /></td>
        </tr>
         <tr>
            <td>确认密码</td>
           <td> <input id="Text3" type="password" /></td>
        </tr>
         <tr>
            <td colspan="2" align="center">
                <input id="btnTeacher" type="button" value="保存" class="btnOK" /></td>
        </tr>
    </table>
</asp:Content>
