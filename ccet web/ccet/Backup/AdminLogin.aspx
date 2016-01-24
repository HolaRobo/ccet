<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="LabManage.Login_User" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户登录</title>

    <script language="javascript" type="text/javascript" src="Script/jquery-1.4.4.js"></script>

    <link href="Style/Style_AdminLogin.css" rel="stylesheet" type="text/css" />

    <script language="javascript" type="text/javascript" src="Script/Js_AdminLogin.js"></script>
    
</head>
<body>
<div class="page">
	<div class="header">
		<h1 class="logo">
			<span style="display:none;">用户登录</span>
		</h1>
		<div class="toplinks">
			<a href="MainForm.aspx">返回首页</a> 
		</div>
	</div>
	<div class="body">
		<div class="part main-part">
			<div class="mod login-mod">
					<div class="fi">
						<label class="tit">用户名</label>
						<input type="text" name="account_name" id="account_name" class="ipt-t ipt-sample" value="">
					</div>
					<div class="fi">
						<label class="tit">密　码</label>
						<input type="password" class="ipt-t" name="password" id="password">
					</div>
					<div class="fi fi-notit">
						<input type="button" id="btnLogin" class="ipt-b" value="登　录">
					</div>
			</div>
		</div>
	</div>
</div>
</body>
</html>
