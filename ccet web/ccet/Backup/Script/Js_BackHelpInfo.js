$(function() {
    $("#idMyTable .btnDelete").click(function() {
        //判断登录是否有效
        if (getCookie("CookieUserID") == null) {
            alert("你还没登录或登录已经超时,请重新登录！");
            return false;
        }

        var _r = confirm("确定删除吗");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "DeleteHelp", HelpID: $(this).attr("id") }, function(data, textStatus) {
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