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
    <link rel="Stylesheet" href="Style/Style_LostAndFound_Admin.css" />
    <script type="text/javascript" language="javascript" src="Script/jquery-1.4.4.js"></script>
    <script type="text/javascript" language="javascript" src="Script/bootstrap.min.js"></script>
    <script type="text/javascript" language="javascript" src="Script/bootstrap.js"></script>
    <script type="text/javascript" language="javascript" src="Script/npmjs"></script>
    <script type="text/javascript" language="javascript" src="My97DatePicker/WdatePicker.js"></script>

    <div class="test" id="test1" runat="server">

    </div>
    <%-- %>script language="javascript" type="text/javascript">
        $(document).ready(function(){
            $("<div/>", {
                "class":"MyClass",
                "id": "MyId",
                "text": "Here is DIV inner"
            }).appendTo("#test1");
        });
    <--%>
</asp:Content>
