<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master"
    AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="LabManage.MainForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="Style/Style_MainForm.css" />
    <link rel="Stylesheet" href="Style/css_xunlei.css" />
    <script type="text/javascript" src="Script/funcs.js"></script>
    <script type="text/javascript" language="javascript" src="Script/Js_MainForm.js"></script>
    <div class="MainForm_warp">
        <div class="MainForm_top">
            <div class="new">
                <div class="title"><a href="">新闻公告</a></div>
                <div>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <HeaderTemplate>
                            <ul>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li><a class="a1" href='<%#"NewsInfo.aspx?NewsID="+Eval("NewsID") %>'>
                                <%#Eval("NewsTitle")%></a> <span class="span1">
                                    <%#Eval("PublicTime")%></span>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ul></FooterTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <div class="image">

                <script type="text/javascript">
                    var MaxScreen = 7;
                    var CurScreen = 1;
                </script>

                <div class="flashNews">
                    <div id="Switch_1">
                        <a href="http://www.chinaz.com/" target="_blank" blockid="1121">
                            <img src="img/01.jpg" alt="功夫世界" onmouseover="pauseSwitch();" onmouseout="goonSwitch();" /></a></div>
                    <div id="Switch_2" style="display: none;">
                        <a href="http://www.chinaz.com/" target="_blank" blockid="1121">
                            <img src="img/02.jpg" alt="康师傅茉莉清茶" onmouseover="pauseSwitch();" onmouseout="goonSwitch();" /></a></div>
                    <div id="Switch_3" style="display: none;">
                        <a href="http://www.chinaz.com/" target="_blank" blockid="1121">
                            <img src="img/03.jpg" alt="VANCL 凡客城品" onmouseover="pauseSwitch();" onmouseout="goonSwitch();" /></a></div>
                    <div id="Switch_4" style="display: none;">
                        <a href="http://www.chinaz.com/" target="_blank" blockid="1121">
                            <img src="img/04.jpg" alt="赎命24小时" onmouseover="pauseSwitch();" onmouseout="goonSwitch();" /></a></div>
                    <div id="Switch_5" style="display: none;">
                        <a href="http://www.chinaz.com/" target="_blank" blockid="1121">
                            <img src="img/05.jpg" alt="耀眼的日子" onmouseover="pauseSwitch();" onmouseout="goonSwitch();" /></a></div>
                    <div id="Switch_6" style="display: none;">
                        <a href="http://www.chinaz.com/" target="_blank" blockid="1121">
                            <img src="img/06.jpg" alt="星河舰队3" onmouseover="pauseSwitch();" onmouseout="goonSwitch();" /></a></div>
                    <div id="Switch_7" style="display: none;">
                        <a href="http://www.chinaz.com/" target="_blank" blockid="1121">
                            <img src="img/07.jpg" alt="全民超人汉考克" onmouseover="pauseSwitch();" onmouseout="goonSwitch();" /></a></div>
                    <div id="SwitchTitle" onmouseover="pauseSwitch();" onmouseout="goonSwitch();">
                    </div>
                    <ul id="SwitchNav">
                    </ul>
                    <div class="bg" onmouseover="pauseSwitch();" onmouseout="goonSwitch();">
                    </div>
                </div>

                <script type="text/javascript" language="javascript">
                    var Switcher = new Array();
                    Switcher[1] = Array();
                    Switcher[1]['title'] = "功夫世界";
                    Switcher[1]['stitle'] = "每天送礼再升级 更多豪礼拿不停";
                    Switcher[1]['link'] = "http://www.chinaz.com/";
                    Switcher[2] = Array();
                    Switcher[2]['title'] = "康师傅茉莉清茶";
                    Switcher[2]['stitle'] = "创意生活 晒出你的新创意";
                    Switcher[2]['link'] = "http://www.chinaz.com/";
                    Switcher[3] = Array();
                    Switcher[3]['title'] = "VANCL 凡客城品";
                    Switcher[3]['stitle'] = "低价新体验 火爆促销中";
                    Switcher[3]['link'] = "http://www.chinaz.com/";
                    Switcher[4] = Array();
                    Switcher[4]['title'] = "赎命24小时";
                    Switcher[4]['stitle'] = "电影版-步步涉险分分惊魂";
                    Switcher[4]['link'] = "http://www.chinaz.com/";
                    Switcher[5] = Array();
                    Switcher[5]['title'] = "耀眼的日子";
                    Switcher[5]['stitle'] = "点燃激情的动力，捍卫生命的奇迹";
                    Switcher[5]['link'] = "http://www.chinaz.com/";
                    Switcher[6] = Array();
                    Switcher[6]['title'] = "星河舰队3";
                    Switcher[6]['stitle'] = "重力打造强势回归，继续与异形战斗";
                    Switcher[6]['link'] = "http://www.chinaz.com/";
                    Switcher[7] = Array();
                    Switcher[7]['title'] = "全民超人汉考克";
                    Switcher[7]['stitle'] = "票房“超人”威尔·史密斯最新力作枪版";
                    Switcher[7]['link'] = "http://www.chinaz.com/";

                    var refreshSwitchTimer = null;
                    switchPic(CurScreen);
                    refreshSwitchTimer = setTimeout('reSwitchPic();', 300000);
                </script>

            </div>
            <div  style="clear:both"></div>
        </div>
        <div class="MainForm_bottom">
            <ul>
                <li class="up" id="menu0"><a  href="LabInfoList.aspx">实验室预约</a></li>
                 <li id="Li1"><a href="ReplyList.aspx" >留言记录</a></li>
                <li id="menu1"><a href="LeaveMessage.aspx" >在线留言</a></li>
                <li id="li_MyAppointment"><a href="#" >我的预约</a></li>
                <li id="menu2"><a href="UserLogin.aspx" >登录 </a></li>
                <%-- <li id="Li2"><a href="UpdateTeacherPwd.aspx" >修改密码</a></li>--%>
            </ul>
        </div>
    </div>
</asp:Content>
