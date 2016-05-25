<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Masters/ForeGroundMaster.Master" 
    CodeBehind="LostAndFound_Admin2.aspx.cs" Inherits="LabManage.LostAndFound_Admin2" %>

<%-- %><!DOCTYPE html>--%>




<asp:Content ID="Content1" ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    
    <link rel="Stylesheet" href="Style/bootstrap.min.css" type="text/css"/>
    <link rel="Stylesheet" href="Style/bootstrap.css" type="text/css" />
    <link rel="Stylesheet" href="Style/bootstrap-theme.min.css" type="text/css" />
    <link rel="Stylesheet" href="Style/bootstrap-theme.css" type="text/css" />
    <link rel="Stylesheet" href="Style/Style_LostAndFound_List.css" />
    <script type="text/javascript" language="javascript" src="Script/jquery-1.12.4.js"></script>
    <script type="text/javascript" language="javascript" src="Script/bootstrap.min.js"></script>
    <script type="text/javascript" language="javascript" src="Script/bootstrap.js"></script>
    <script type="text/javascript" language="javascript" src="Script/npm.js"></script>
    <script type="text/javascript" language="javascript" src="My97DatePicker/WdatePicker.js"></script>


    <div class="type">
        <asp:Button id="digital" name ="digital" class="btn btn-success" onclick="jifang" Text="电子产品" runat="server"></asp:Button>
        <asp:Button id="book" name ="book" class="btn btn-warning" onclick="jifang" Text="书籍资料" runat="server"></asp:Button>
        <asp:Button id="other" name ="other" class="btn btn-primary" onclick="jifang" Text="其他" runat="server"></asp:Button>

        <asp:Button id="found" name ="found" style="margin-left:100px;" class="btn btn-danger" onclick="jifang" Text="已被领取" runat="server"></asp:Button>
    </div>

    <div class="content">
        <div class="btn-group-vertical">
            <asp:Button id="button51" name="button51" class="btn btn-info" onclick="jifang" Text="第一机房" runat="server"></asp:Button>
            <asp:Button id="button6" name="button6" class="btn btn-info" onclick="jifang" Text="第二机房" runat="server"></asp:Button>
            <asp:Button id="button7" name="button7" class="btn btn-info" onclick="jifang" Text="第三机房" runat="server"></asp:Button>
            <asp:Button id="button8" name="button8" class="btn btn-info" onclick="jifang" Text="第四机房" runat="server"></asp:Button>
            <asp:Button id="button9" name="button9" class="btn btn-info" onclick="jifang" Text="第五机房" runat="server"></asp:Button>
            <asp:Button id="button10" name="button10" class="btn btn-info" onclick="jifang" Text="第六机房" runat="server"></asp:Button>
            <asp:Button id="button11" name="button11" class="btn btn-info" onclick="jifang" Text="第七机房" runat="server"></asp:Button>
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
