<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/ForeGroundMaster.Master"
    AutoEventWireup="true" CodeBehind="LabAppointment.aspx.cs" Inherits="LabManage.LabAppointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript" language="javascript" src="My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript" language="javascript" src="Script/Js_LabAppointment.js"></script>

    <link rel="stylesheet" type="text/css" href="Style/Style_LabAppointment.css" />
    <div class="LabAppointment_top"> 
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>该实验室当前预约情况  <input id="Button1" type="button" value="我的预约"  class="btnClass3" onclick="window.location.href='MyAppointment.aspx'"/></div>
    <div class="LabAppointment_center">
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table border="0" cellpadding="0" cellspacing="0" id="idMyTable">
                    <tr>
                        <th class="nobg">日期</th>
                        <th>1、2节</th>
                        <th>3、4节</th>
                        <th>3、4、5节</th>
                        <th>6、7节</th>
                        <th>6、7、8节</th>
                        <th>8、9节</th>
                        <th>10、11节</th>
                        <th>10、11、12节</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td class="spec"><%#Convert.ToDateTime(Eval("Appdate")).ToShortDateString()%></td>
                    <td><%#Eval("App12")%></td>
                    <td><%#Eval("App34")%></td>
                    <td><%#Eval("App345")%></td>
                    <td><%#Eval("App67")%></td>
                    <td><%#Eval("App678")%></td>
                    <td><%#Eval("App89")%></td>
                    <td><%#Eval("App1011")%></td>
                    <td><%#Eval("App101112")%></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table></FooterTemplate>
        </asp:Repeater>
    </div> 
    <fieldset  class="LabAppointment_bottom">
      <legend>我要预约</legend>
           预约时间：<input id="Text2" type="text" onClick="WdatePicker()"/> <br />
           &nbsp;<input id="Radio1" class="Radio" name="radio1" type="radio" value="12" checked />1、2节
           &nbsp;<span>|</span><input id="Radio2" class="Radio" name="radio1" type="radio" value="34" />3、4节
           &nbsp;<span>|</span><input id="Radio3" class="Radio" name="radio1" type="radio" value="345" />3、4、5节
           &nbsp;<span>|</span><input id="Radio4" class="Radio" name="radio1" type="radio" value="67" />6、7节
           &nbsp;<span>|</span><input id="Radio5" class="Radio" name="radio1" type="radio" value="678" checked />6、7、8节
           &nbsp;<span>|</span><input id="Radio6" class="Radio" name="radio1" type="radio" value="89" />8、9节
           &nbsp;<span>|</span><input id="Radio7" class="Radio" name="radio1" type="radio" value="1011" />10、11节
           &nbsp;<span>|</span><input id="Radio8" class="Radio" name="radio1" type="radio" value="101112" />10、11、12节
           <p>留言</p>
           <textarea id="TextArea1" cols="40" rows="4" class="TextArea1"></textarea>
           <br />
           <input id="idbtnOK" type="button" value="确定预约" class="btnOK" />
           <br />
    </fieldset>
</asp:Content>
