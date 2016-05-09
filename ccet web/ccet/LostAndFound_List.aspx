<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Masters/ForeGroundMaster.Master" 
    CodeBehind="LostAndFound_List.aspx.cs" Inherits="LabManage.LostAndFound_List" %>

<%-- %><!DOCTYPE html>--%>


<%-- <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
<--%>


<asp:Content ID="Content1" ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    
    <link rel="Stylesheet" href="Style/bootstrap.min.css" type="text/css"/>
    <link rel="Stylesheet" href="Style/bootstrap.css" type="text/css" />
    <link rel="Stylesheet" href="Style/bootstrap-theme.min.css" type="text/css" />
    <link rel="Stylesheet" href="Style/bootstrap-theme.css" type="text/css" />
    <link rel="Stylesheet" href="Style/Style_LostAndFound_List.css" />
    <script type="text/javascript" language="javascript" src="Script/jquery-1.4.4.js"></script>
    <script type="text/javascript" language="javascript" src="Script/bootstrap.min.js"></script>
    <script type="text/javascript" language="javascript" src="Script/bootstrap.js"></script>
    <script type="text/javascript" language="javascript" src="Script/npm.js"></script>
    <script type="text/javascript" language="javascript" src="My97DatePicker/WdatePicker.js"></script>


    <div class="type">
        <button id="digital" name ="digital" type ="button" class="btn btn-success">电子产品</button>
        <button id="book" name ="book" type ="button" class="btn btn-warning">书籍资料</button>
        <button id="other" name ="other" type ="button" class="btn btn-primary">其他物品</button>

        <button id="found" name ="found" type ="button" style="margin-left:100px;" class="btn btn-danger">已被领取</button>
    </div>

    <div class="content">
        <div class="btn-group-vertical">
            <button type="button" class="btn btn-info" onClick="first">第一机房</button>
            <button type="button" class="btn btn-info" onClick="second">第二机房</button>
            <button type="button" class="btn btn-info" onClick="thress">第三机房</button>
            <button type="button" class="btn btn-info" onClick="four">第四机房</button>
            <button type="button" class="btn btn-info" onClick="five">第五机房</button>
            <button type="button" class="btn btn-info" onClick="six">第六机房</button>
            <button type="button" class="btn btn-info" onClick="seven">第七机房</button>
        </div>

        <div class="list">
            <asp:Panel ID ="panel1" runat="server" Height="800px" Width="800px" ScrollBars="Vertical">
                <table border="0" cellspacing="0" cellpadding="0" id="d_table" runat="server"></table>
            </asp:Panel>
        </div>

        <div class="test">
            
        </div>
        
    </div>

    
</asp:Content>
