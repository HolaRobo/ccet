<%@ Page Language="C#"  MasterPageFile="~/Masters/ForeGroundMaster.Master" AutoEventWireup="true" 
    CodeBehind="LostAndFound_Admin.aspx.cs" Inherits="LabManage.LostAndFound_Admin" %>


<asp:Content ID="Content1" ContentPlaceHolderId="ContentPlaceHolder1" runat="server">
    
    <link rel="Stylesheet" href="Style/bootstrap.min.css" type="text/css"/>
    <link rel="Stylesheet" href="Style/bootstrap.css" type="text/css" />
    <link rel="Stylesheet" href="Style/bootstrap-theme.min.css" type="text/css" />
    <link rel="Stylesheet" href="Style/bootstrap-theme.css" type="text/css" />
    <link rel="Stylesheet" href="Style/Style_LostAndFound_Admin.css" />
    <script type="text/javascript" language="javascript" src="Script/bootstrap.min.js"></script>
    <script type="text/javascript" language="javascript" src="Script/bootstrap.js"></script>
    <script type="text/javascript" language="javascript" src="Script/npmjs"></script>
    <script type="text/javascript" language="javascript" src="My97DatePicker/WdatePicker.js"></script>

    <%-- %>div class="LostAndFound_Admin_wrap"--%>
        <div class ="name">

            <asp:Label ID="nameLabel" CssClass="btn-success btn-lg" runat="server" Text="失物名称" ForeColor="White"></asp:Label>
         
            <input id="input1" name="lostName" type="text" class="form-control" placeholder="失物名称(不能为空)" />


        </div>

       <div class ="classification">
           <asp:Label ID="classLabel" CssClass="btn-success btn-lg" runat="server" Text="失物类别" ForceColor="White"></asp:Label>
           <asp:DropDownList ID="DropDownList2" name="classify" CssClass="btn-info btn-lg" runat="server" style="margin-left:28px; height:43px; margin-top: -8px;">
                <asp:ListItem>电子产品</asp:ListItem>
                <asp:ListItem>书籍资料</asp:ListItem>
                <asp:ListItem>其他</asp:ListItem>
            </asp:DropDownList>
       </div>

        <div class="lost_loc">

            <asp:Label ID="locLabel" CssClass="btn-success btn-lg" runat="server" Text="丢失地点" ForceColor="White"></asp:Label>
            <asp:DropDownList ID="roomSelect" name="roomSelect" CssClass="btn-info btn-lg" runat="server" style="margin-left:28px; height:43px; margin-top: -8px;">
                <asp:ListItem>第一机房</asp:ListItem>
                <asp:ListItem>第二机房</asp:ListItem>
                <asp:ListItem>第三机房</asp:ListItem>
                <asp:ListItem>第四机房</asp:ListItem>
                <asp:ListItem>第五机房</asp:ListItem>
                <asp:ListItem>第六机房</asp:ListItem>
                <asp:ListItem>第七机房</asp:ListItem>
                <asp:ListItem>其他</asp:ListItem>
            </asp:DropDownList>

        </div>

        <div class ="dateTime">
            <asp:Label ID="dateLabel" CssClass =" btn-success btn-lg" runat="server" Text="丢失日期"></asp:Label>
            <input id="input2" name="dateInput" style="position:relative; left:134px;top:-29px;width:188px;" type="text" class="form-control" placeholder="选择日期(不能为空)" onClick="WdatePicker()"; />
        </div>

        <div class="description">

            <asp:Label ID="desLabel" CssClass="btn-success btn-lg" runat="server" Text="简单描述"></asp:Label>
            <textarea ID="des" name="textArea" type="text" class="form-control" runat="server" placeholder="失物简单描述" wrap="virtual" rows="3" cols="20"></textarea>
        </div>

        <div class="load_picture">
            
            <%-- %>asp:Label ID="msgLabel" CssClass="btn-success btn-lg" Text="可以上传图片" runat="server"></%>
            <asp:FileUpload ID="FileUpload1" CssClass="btn btn-primary-outline btn-lg" runat="server" Style="margin-left:200px; margin-top:-33px;"/>
            <asp:Button ID ="loadButton" CssClass="btn btn-warning btn-lg" Text="上传图片" Style="margin-top:-380px;margin-left:300px;" OnClick="picLoadClick" runat="server" />
            <asp:Label ID="loadLabel" runat="server" Text ="" Style="color:orangered"></asp:Label>
            <asp:Image ID="loadImage" CssClass="inputc" Style="margin-left:100px; margin-top:30px;" Width="300px" Height="300px" runat="server"/--%>
            <asp:FileUpload ID="FileUpload1" name="fileupload" CssClass="btn btn-primary-outline btn-lg" runat="server"/>
            <asp:Button ID ="loadButton" CssClass="btn btn-warning btn-lg" Text="上传图片" Style="margin-top:-60px;margin-left:630px;" OnClick="picLoadClick" runat="server" />
            <asp:Label ID="loadLabel" runat="server" Text ="" Style="color:orangered"></asp:Label>
            <asp:Image ID="loadImage" CssClass="inputc"  runat="server"/>
             
            
        </div>

        <div class="submit">
            <asp:Button ID="subButton" name="button1" CssClass="btn-warning btn-lg" Text="信息提交"  onClick="submitClick" runat="server" />
        </div>

        

</asp:Content>