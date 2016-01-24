$(function() {
    var _SysORSaf = GetUrlParaValue("Command"); //是制度还是安全
    if (_SysORSaf == "System") {
        //为制度
        document.title = "管理制度";

    }
    else {
        document.title = "环境与安全";
    }
    $("#backMaster_right1").text(document.title);
    var _MyID = 0;
    if (GetUrlParaValue("ActionID") != "") {
        _MyID = GetUrlParaValue("ActionID");
    }
    var _CreORUpd = GetUrlParaValue("CreORUpd"); //是更新还是创建
    if (_CreORUpd == "Upd") {
        $("#txtTitle").val(decodeURI(GetUrlParaValue("Title")));
        $.get("Handler1.ashx", { Action: "SearchSystemAndSafetyContent", Command: _SysORSaf, MyID: _MyID }, function(data, textStatus) {
            KE.html("TextArea1", data)
        })
    }


    $("#btnUpd").click(function() {

        var obj_Title = $("#txtTitle").val();
        if (obj_Title == "") {
            alert("请输入标题");
            return;
        }
        var obj_content = $("#TextArea1").val();

        if (obj_content == "") {
            alert("请输入内容");
            return;
        }
        if (obj_content.length < 20) {
            alert("内容长度太短,请完善");
            return;
        }
        var _r = confirm("确定保存吗？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "UpdateSystemAndSafety", CreORUpd:_CreORUpd, Command: _SysORSaf, MyID: _MyID,Title:obj_Title,Content:obj_content }, function(data, textStatus) {
                if (data != "0") {
                    alert("操作成功！");
                }
                else {
                    alert("操作失败！");
                }
            })
        }
    })
})




















/*  $("#btnUpd").click(function() {
  
var obj_Title = $("#txtTitle").val();
if (obj_Title == "") {
alert("请输入标题");
return;
}
var obj_content = $("#TextArea1").val();

if (obj_content == "") {
alert("请输入内容");
return;
}
if (obj_content.length < 20) {
alert("内容长度太短,请完善");
return;
}

var _r = confirm("确定修改吗？");
if (_r == true) {
$.get("Handler1.ashx", { Action: "UpdateNewsInfo", NewsID: GetUrlParaValue("NewsID"), NewsTitle: obj_Title, NewsContent: obj_content }, function(data, textStatus) {
if (data != "0") {
alert("操作成功！");
}
else {
alert("操作失败！");
}
})
}
})*/
