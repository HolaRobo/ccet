<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHeader.ascx.cs" Inherits="LabManage.UserControl.ucHeader" %>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link href="../Style/Style_ucHeader.css" rel="stylesheet" type="text/css" />

<script type="text/javascript" language="javascript" src="../Script/Js_ucHeader.js"></script>
<script language="javascript" type="text/javascript">
    //设定栏目的鼠标事件
    function doClick_risingmenu(o) {
        o.className = "navmenu_on"; var j; var id; var e; for (var i = 1; i <= 7; i++) {
            id = "risingmenu" + i; j = document.getElementById(id); e = document.getElementById("sub_con" + i); if (id != o.id) { j.className = "navmenu_off"; e.style.display = "none"; } else {
                e.style.display = "block";
            }
        }
    }
    //设定栏目的默认选项
    function doView_risingmenu(o, intI, intJ) {
        o.className = "navmenu_on"; var j; var id; var e; var f; for (var i = 1; i <= 7; i++) {
            id = "risingmenu" + i; j = document.getElementById(id); e = document.getElementById("sub_con" + i);
            if (id != "risingmenu" + intI) {   //设置一级的样式
                j.className = "navmenu_off";  //设置二级的不显示
                e.style.display = "none";
            } else {
                j.className = "navmenu_on"; e.style.display = "block"; if (intJ != 0) {
                    f = document.getElementById("sub_con" + i + "_" + intJ);
                    //设置二级的样式
                    f.className = "submenu_on";
                }
            }
        }
    }
</script>
<style>
    /*@import url(subnav.css);*/
#rising_header
{
	margin: auto;
	width: 900px;
	height: 100px;
	padding-top: 14px;
	background: url("img/header_menu_bg_top.gif") left top repeat-x;
	text-align: left;
}
#rising_header img
{
	border: 0;
}
#rising_menu
{
	position: relative;
	padding: 27px 0 0;
	height: 31px;
        top: 0px;
        left: 0px;
    }
#rising_menu #navmenu
{
	height: 27px;
	padding: 0 15px;
	position: absolute;
	top: 1px;
	z-index: 100;
        left: 0px;
    }
#navmenu ul
{
	list-style: none;
}
#navmenu li
{
	float: left;
	text-align:center;
}
#rising_menu #rsoldmenu
{
	height: 27px;
	line-height: 27px;
	position: absolute;
	top: 1px;
	right: 120px;
	z-index: 90;
}
#rising_menu #kakamenu
{
	height: 27px;
	position: absolute;
	top: 1px;
	right: 15px;
	z-index: 90;
}
#rising_menu #qiangmenu
{
	position: absolute;
	top: -13px;
	left: 350px;
	z-index: 200;
}

.navmenu_on, .navmenu_off
{
	display: block;
	font-size: 14px;
	width: 89px;
	height: 27px;
	line-height: 27px;
	cursor: pointer;
	text-align: center;
	font-weight: bold;
}
.navmenu_on
{
	color: #ffffff;
	background: url("img/header_menu_btn_on.gif") bottom left no-repeat;
}
.navmenu_off
{
	color: #2457a8;
	background: url("img/header_menu_btn_off.gif") bottom left no-repeat;
}

.navmenu_on a:link, .navmenu_on a:visited, .navmenu_on a:hover, .navmenu_on a:active, .navmenu_off a:link, .navmenu_off :visited, .navmenu_off a:hover, .navmenu_off a:active
{
	display: block;
	width: 89px;
	height: 27px;
	cursor: pointer;
}

.navmenu_on a:link, .navmenu_on a:visited, .navmenu_on a:hover, .navmenu_on a:active
{
	color: #ffffff;
	text-decoration: none;
}

.navmenu_off a:link, .navmenu_off a:visited, .navmenu_off a:hover, .navmenu_off a:active
{
	color: #2457a8;
	text-decoration: none;
}

.submenu
{
	font-size: 14px;
	background: url("img/header_menu_bg_bottom.gif") left top repeat-x;
	line-height: 31px;
	height: 31px;
	padding: 0 15px;
	color: #FFFFFF;
}
.submenu a:link, .submenu a:visited, .submenu a:hover, .submenu a:active
{
	color: #ffffff;
	text-decoration: none;
}
.submenu_on
{
	color: #FF0000;
}
.subline
{
	font-size: 11px;
	color: #2763A5;
	padding-top: 0;
	padding-right: 10px;
	padding-bottom: 0;
	padding-left: 10px;
}
.none
{
	display: none;
}
.sbcss
{
	clear: both;
	font-size: 0;
	line-height: 0;
	height: 0;
}

.cfff a:link, .cfff a:visited
{
	color: #FFF;
	text-decoration: underline;
}
.cfff a:hover, .cfff a:active
{
	color: #000;
	text-decoration: underline;
}

a:link
{
	color: #2457A8;
	text-decoration: none;
}
a:visited
{
	color: #2457A8;
	text-decoration: none;
}
a:hover
{
	color: #2457A8;
	text-decoration: underline;
}


.btn-buy
{
	margin-left: 5px;
	vertical-align: text-bottom;
}
.subtitle
{
	font-weight: 900;
	border: 1px solid #B9D3F9;
	padding-left: 5px;
	height: 20px;
	background-image: url("img/bg_subtitle.png");
	background-repeat: repeat-x;
	padding-top: 0px;
}
.subtitle span
{
	font-weight: normal;
	float: right;
	margin-right: 5px;
}

.clear
{
	clear: both;
	height: 2px;
	font-size: 0px;
	line-height: 0px;
}
#container
{
	width: 900px;
	margin-right: auto;
	margin-left: auto;
}
#header
{
	clear: both;
}
#main
{
	padding: 10px;
	text-align: left;
}
#ver
{
	clear: both;
}
#ver a
{
	color: #000000;
}
#left
{
	width: 190px;
	float: left;
}
#update
{
	height: 200px;
	border: 1px solid #3A77D0;
	background-image: url("img/bg_update.png");
	background-repeat: repeat-y;
	background-position: left;
	text-align: center;
	margin-top: 10px;
}
#middle
{
	width: 480px;
	float: left;
	margin-right: 10px;
	margin-left: 10px;
}
#slideshow
{
	margin-top: 10px;
	height: 200px;
	width: 480px;
}
#right
{
	float: right;
	width: 190px;
}
#friendslinks
{
	border: 1px solid #B9D3F9;
	padding: 5px;
	margin: 10px;
	text-align: left;
}
#friendslinks span
{
	float: right;
}
#footer
{
	clear: both;
	border-top-width: 1px;
	border-top-style: solid;
	border-top-color: #3A77D0;
	margin-right: 5px;
	margin-left: 5px;
	margin-top: 10px;
	clear: both;
	padding-top: 5px;
}


/**********************/
#subnav
{
	background: url("img/subnav_bg.png") left top repeat-x;
	font-size: 12px;
	mline-height: 20px;
	background-color: #ffffff;
	width: 480px;
	margin-top: 12px;
}
#subnav_menu
{
	padding: 0;
	height: 24px;
	border: #2763A5 1px solid;
	border-bottom: none;
	background: url("img/subnav_menu_bg.png") left top repeat-x;
}
#subnav_menu ul
{
	list-style: none;
	margin-left: 10px;
}
#subnav_menu li
{
	float: left;
}
#subnav_menu li span a
{
	text-align:center;
}
#subnav_sub
{
	color: #000;
	min-height: 89px;
	padding-top: 10px;
}

.subnav_off, .subnav_on
{
	display: block;
	font-size: 12px;
	width: 77px;
	cursor: pointer;
	text-align: center;
	font-weight: bold;
	height: 24px;
	line-height: 24px;
}

.subnav_off
{
	color: #fff;
}
.subnav_off a:link, .subnav_off a:visited
{
	color: #fff;
	text-decoration: none;
}
.subnav_off a:hover, .subnav_off a:active
{
	color: #2457a8;
}

.subnav_on
{
	color: #2457a8;
	background: url("subnav_sub_on.png") bottom center no-repeat;
}
.subnav_on a:link, .subnav_on a:visited
{
	color: #2457a8;
	text-decoration: none;
}
.subnav_on a:hover, .subnav_on a:active
{
	color: #2457a8;
}

.none
{
	display: none;
}
.header_warp
{
	background:url("img/head.jpg");
}
.header_warp .top
{
	height:190px;
}

</style>

<div class="header_warp">
      <img  src="img/head.jpg" width="960" style="height: 160px"/>

    <div id="rising_menu">
        <div id="navmenu">          
            <ul>
                <li><a style="text-decoration:none" href="MainForm.aspx"><span class="navmenu_on" id="risingmenu1" onmouseover="doClick_risingmenu(this);">首页</span></a></li>
                <li><span class="navmenu_off" id="risingmenu2" onmouseover="doClick_risingmenu(this);">中心概况</span></li>
                <li><span class="navmenu_off" id="risingmenu3" onmouseover="doClick_risingmenu(this);">管理模式</span></li>
                <li><span class="navmenu_off" id="risingmenu4" onmouseover="doClick_risingmenu(this);">设备环境</span></li>
                <li><span class="navmenu_off" id="risingmenu5" onmouseover="doClick_risingmenu(this);">教学成果</span></li>
                <li><span class="navmenu_off" id="risingmenu6" onmouseover="doClick_risingmenu(this);">教学资源</span></li>
                <li><span class="navmenu_off" id="risingmenu7" onmouseover="doClick_risingmenu(this);">机房预约</span></li>
            </ul>
        </div>
        <div class="submenu">
            <div class="" id="sub_con1">
                <a href="NewsInfoList.aspx">通知公告</a></div>
            <div class="none" id="sub_con2">
                <a href="PublicPage.aspx?Para=CenterAbstruct">中心简介</a><span class="subline">|</span><a href="Centerframework.aspx">中心架构</a><span class="subline">|</span><a
                    href="CenterTeam.aspx">中心队伍</a></div>
            <div class="none" id="sub_con3">
                <a href="LabManageSystemList.aspx">管理制度</a><span class="subline">|</span><a href="PublicPage.aspx?Para=DevelopPlan">发展规划</a></div>
            <div class="none" id="sub_con4">
                <a href="DrviceMaintenanceList.aspx">设备的运行与维护</a><span class="subline">|</span><a href="LabSafetyInfoList.aspx">环境与安全</a></div>
            <div class="none" id="sub_con5">
                <a href="PublicPage.aspx?Para=StudentResult">学生学习成果</a><span class="subline">|</span><a href="PublicPage.aspx?Para=TeacherResult">实验教学成果</a></div>
            <div class="none" id="sub_con6">
                <a href="ResourceDown.aspx?TypeName=表格资源">资源下载</a></div>
            <div class="none" id="sub_con7">
                <a href="LabOrder.aspx">预约情况</a></div>
        </div>
    </div>
</div>