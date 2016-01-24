$(function() {
    $("#idbtnOK").click(function() {
        var obj_Content = $("#TextArea1").val();
        if (obj_Content == "") {
            alert("请输入留言内容");
            return;
        }

        var _r = confirm("你确定给他留言吗？");
        var _IsTeacher = $("input[name='radio1']:checked").val();
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "InsertLeaveMessage",
                LeaveManName: $("#Text1").val(),
                IsTeacher: _IsTeacher,
                LeaveMessageContent: obj_Content
            }, function(data, textStatus) {
                if (data == "1") {
                    alert('留言成功');
                }
                else {
                    alert('留言失败');

                }

            })
        }
    })
})

