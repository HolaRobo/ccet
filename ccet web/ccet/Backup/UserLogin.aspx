<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="LabManage.UserLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!-- saved from url=(0033)http://emlc.yangtzeu.edu.cn/syjx/ -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=GBK">
    <title>实验教学管理系统</title>
   <script type="text/javascript" language="javascript" src="Script/jquery-1.4.4.js"></script>
    <script type="text/javascript" language="javascript" src="Script/Js_UserLogin.js"></script>
    <link rel="stylesheet"  type="text/css" href="Style/Style_UserLogin.css" />
</head>
<body>
    <form name="login" method="post">
        <table style="width:596px; background:url(./img/login.jpg); height:200px; margin:200px auto" border="0" cellpadding="0"  cellspacing="0" align="center">
            <!--DWLayoutTable-->
            <tbody>
                <tr>
                    <td width="219" height="95">
                        &nbsp;
                    </td>
                    <td width="360">
                        &nbsp;
                    </td>
                    <td width="17">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td height="200">
                    </td>
                    <td valign="top">
                        <table width="100%" border="0" cellpadding="0" cellspacing="0">
                            <!--DWLayoutTable-->
                            <tbody>
                                <tr>
                                    <td width="120" height="21">
                                        &nbsp;
                                    </td>
                                    <td width="143">
                                        &nbsp;
                                    </td>
                                    <td width="97">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td height="35" align="center" valign="middle">
                                        <img src="img/user.gif" width="120" height="30">
                                    </td>
                                    <td align="left" valign="middle">
                                        <input style="width: 140px" class="input1"  maxlength="32"
                                            name="username" id="username">
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td height="35" valign="top">
                                        <img src="img/pass.gif" width="120" height="30">
                                    </td>
                                    <td align="left" valign="middle">
                                        <input style="width: 140px" class="input1"  maxlength="32"
                                            type="password" name="pass" id="password">
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="44" colspan="3" align="center" valign="middle">
                                        <input type="radio" name="identity" value="teacher" checked>教师
                                        <input type="radio" name="identity" value="admin"> 管理员
                                    </td>
                                </tr>
                                <tr>
                                    <td height="60" colspan="3" align="center" valign="middle">
                                        &nbsp;
                                        <input id="idbtnLogin" type="button" style="background-image: url(img/login_dl.gif);
                                            border-bottom: 0px; border-left: 0px; width: 127px; height: 36px; border-top: 0px;
                                           cursor:pointer;  border-right: 0px" value=" "/>
                                        <input name="button" type="button" style="background-image: url(img/login_gb.gif);
                                            border-bottom: 0px; border-left: 0px; width: 106px; height: 36px; border-top: 0px;
                                           cursor:pointer; border-right: 0px" onclick="window.close()" value=" ">
                                    </td>
                                </tr>
                                <tr>
                                    <td height="8">
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="2">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td height="1">
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </tbody>
        </table>
    </form>
</body>
</html>
