<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/BackMaster.Master" AutoEventWireup="true" CodeBehind="BackSystemAndSafety.aspx.cs" Inherits="LabManage.BackSystemAndSafety" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript" src="Script/Js_BackSystemAndSafety.js"></script>
    <link rel="stylesheet" type="text/css" href="Style/Style_BackSystemAndSafety.css" />
    <div style=" height:50px;"> <input id="btnCreate" type="button" value="创建" class="btnCreate" /></div>
 <asp:Repeater ID="Repeater1" runat="server">
          <HeaderTemplate>
              <table border="0" cellpadding="0" cellspacing="0" id="idMyTable">
                  <tr>
                           <th class="nobg">序号</th>
                           <th class="title">条例</th>
                           <th class="th_btn">编辑</th>
                           <th class="th_btn">删除</th>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td class="spec"><%# Container.ItemIndex+1 %></td>
                              <td ><%#Eval("mytitle")%></td>
                                 <td><input type="button" value="编辑"  onclick="window.location.href='BackSystemAndSafetyUpd.aspx?ActionID=<%#Eval("myid")%>&Command=<%#Eval("Command")%>&Title=<%#Eval("mytitle")%>&CreORUpd=Upd'" class="btnclass" /></td>
                                  <td><input id=<%#Eval("myid")%> type="button" value="删除"  class="btnDel btnclass"/></td>
                                 
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table></FooterTemplate>
                </asp:Repeater>
</asp:Content>
