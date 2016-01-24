<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master" AutoEventWireup="true"
    CodeBehind="UpdateTeacherPwd.aspx.cs" Inherits="LabManage.UpdateTeacherPwd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="Style/Style_UpdateTeacherPwd.css" />
    <script type="text/javascript" language="javascript" src="Script/Js_UpdateTeacherPwd.js"></script>
    <table border="0" cellspacing="0" class="myTable">
        <tr>
            <td colspan="2" class="td_title" id="td_title">修改密码</td>
        </tr>
          <tr>
            <td>教师登录名</td>
            <td> <input id="Text1" type="text" /></td>
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
                <input id="btnTeacher" type="button" value="保存" class="btnClass1" /></td>
        </tr>
    </table>
</asp:Content>
