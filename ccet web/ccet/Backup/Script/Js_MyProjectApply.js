$(function() {

    document.title = "我的申报情况-项目申报与管理系统";
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
    //申请结题
    $("#idTable .btnApplyCom").click(function() {
        var _obj = $(this).parent().parent().prev().find("td").eq(1);
        if ($(_obj).text() == "已审待结") {
            var _r = confirm("确定申请结题吗？");
            if (_r == true) {
                $.get("Handler1.ashx", { Action: "ApplyComplete", ProjectID: $(this).attr("id") }, function(data, textStatus) {
                    if (data != "0") {
                        alert("操作成功！");
                        $(_obj).text("已申请结题") 
                    }
                    else {
                        alert("操作失败！");
                    }
                })
            }
        }
        else {
            alert("改项目当前状态不允许申请结题");
        }
    })

})
