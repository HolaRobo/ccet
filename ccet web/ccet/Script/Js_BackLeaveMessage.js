$(function() {
    document.title = "留言信息";
    $("#backMaster_right1").text(document.title);
    $("#idMyTable .btnDel").click(function() {
        var _r = confirm("确定删除吗？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "DeleteLeaveMessage", LeaveMessageID: $(this).attr("id") }, function(data, textStatus) {
                if (data == "1") {
                    alert("操作成功！");
                    //location.reload();
                    window.location = window.location
                }
                else {
                    alert("操作失败！");
                }
            })
        }
    })
})
var _leaveMessageID = 0;
$(function() {
    $("#idMyTable .btnUpd").click(function() {
        _leaveMessageID = $(this).attr("id");
        var _obj = $(this).parent().parent().find("td");
        $("#Text1").val($(_obj).eq(0).text());
        $("#Text2").val($(_obj).eq(2).text());
        $("#Text3").val($(_obj).eq(4).text());
    })
})
$(function() {
    $("#btnReply").click(function() {
        if (_leaveMessageID == 0) {
            alert("请选择要回复的留言");
            return;
        }
        var _obj_content = $("#Text3").val();
        if (_obj_content == "") {
            alert("请输入回复内容");
            return;
        }
        var _r = confirm("确定回复吗？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "UpdateLeaveMessage", LeaveID: _leaveMessageID, ReplyContent:_obj_content}, function(data, textStatus) {
                if (data == "1") {
                    alert("操作成功！");
                    window.location = window.location
                }
                else {
                    alert("操作失败！");
                }
            })
        }
    })
})