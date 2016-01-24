$(function() {
    $("#idMyTable .btnDel").click(function() {
        var _r = confirm("确定删除吗？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "DeleteTeacherInfo", TeacherID: $(this).attr("id") }, function(data, textStatus) {
                if (data == "1") {
                    alert("操作成功！");
                    location.reload();
                }
                else {
                    alert("操作失败(可能该教师存在预约记录,不能删除)！");
                }
            })
        }
    })
})