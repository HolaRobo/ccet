$(function() {

    document.title = "后台管理-申报管理";

    $("#idTable .btnDelete").click(function() {
        var _r = confirm("确定删除吗？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "DeleteProjectInfo", ProjectID: $(this).attr("id") }, function(data, textStatus) {
                if (data != "0") {
                    alert("操作成功！");
                    location.reload();
                }
                else {
                    alert("操作失败！");
                }
            })
        }
    })
})

