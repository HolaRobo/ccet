<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/BackMaster.Master" AutoEventWireup="true"
    CodeBehind="BackaccraditationLabApp.aspx.cs" Inherits="LabManage.BackaccraditationLabApp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<script type="text/javascript" language="javascript" src="My97DatePicker/WdatePicker.js"></script>

    <script type="text/javascript" language="javascript" src="Script/Js_BackaccraditationLabApp.js"></script>

    <link rel="stylesheet" type="text/css" href="Style/Style_BackaccraditationLabApp.css" />
    <div class="BackaccraditationLabApp_top">预约信息</div>
    <table border="0" cellspacing="0" class="mytable">
        <tr>
            <td>预约教师</td> <td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            <td>预约时间</td> <td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
            <td>实验室</td> <td><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
            <td>实验室类型</td> <td><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
        </tr>
         <tr>
            <td>预约留言</td> <td><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
            <td>审批情况</td> <td><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
            <td>审批留言</td> <td><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
            <td colspan="2"> <input id="btndel" type="button" value="删除该预约" /></td>
        </tr>
    </table>
    <fieldset class="BackaccraditationLabApp_bottom">
        <legend>我的操作</legend>
        &nbsp;<input id="Radio1" class="Radio" name="radio1" type="radio" value="1"
            checked />批准 &nbsp;<input id="Radio2" class="Radio" name="radio1" type="radio" value="0" />不批准
        <p>给他留言</p>
        <textarea id="TextArea1" cols="60" rows="6" class="TextArea1"></textarea>
        <br />
        <input id="idbtnOK" type="button" value="确定" class="btnOK" class="btnOK" />
        <br />
    </fieldset>
</asp:Content>
