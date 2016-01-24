<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/BackMaster.Master" AutoEventWireup="true" CodeBehind="BackPublicPage.aspx.cs" Inherits="LabManage.BackPublicPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="Style/Style_BackPublicPage.css" />

    <script type="text/javascript" language="javascript" src="Script/Js_BackPublicPage.js"></script>
    <script type="text/javascript" charset="utf-8" src="kindeditor/kindeditor.js"></script>
    <script language="javascript" type="text/javascript">
        KE.show({
        id: 'TextArea1',
            resizeMode: 0, /*不能改变编辑器大小*/
            filterMode: false, /*不过滤代码*/
            allowUpload: false,
            items: [
               'fontsize', 'textcolor', 'bgcolor', 'bold', 'italic', 'underline', 'advtable',

                'removeformat', '|', 'justifyleft', 'justifycenter', 'justifyright', 'insertorderedlist',

                'insertunorderedlist', '|']

        });
</script>
    <div class="BackPublicPage_top" id="BackPublicPage_top">发布新闻公告</div>
    <div class="BackPublicPage_content">
        <textarea id="TextArea1" cols="100" rows="25" class="TextArea" ></textarea>
        <input id="btnSave" type="button" value="确定" class="btnCreate"/>
    </div>
</asp:Content>
