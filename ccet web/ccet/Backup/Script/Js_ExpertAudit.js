$(function() {
    $("#idMyTable .btnClass2").click(function() {
        //判断登录是否有效
        if (getCookie("CookieUserID") == null) {
            alert("你还没登录或登录已经超时,请重新登录！");
            return false;
        }
        //同意结题
        var obj_state = $(this).parent().siblings().eq(5).text();
        if (obj_state != "已申请结题") {
            alert("该项目还不能结题！");
            return;
        }
        else {
            var _r = confirm("确定【结题同意】吗");
            if (_r == true) {
                $.get("Handler1.ashx", { Action: "ExpertAuditProject", OperatorID: getCookie("CookieUserID"), ProjectID: $(this).attr("id") }, function(data, textStatus) {
                    if (data != "0") {
                        alert("操作成功！");
                        location.reload();
                    }
                    else {
                        alert("操作失败！");
                    }
                })

            }
        }
    })
    $("#idMyTable .btnClass1").click(function() {
        //判断登录是否有效
        if (getCookie("CookieUserID") == null) {
            alert("你还没登录或登录已经超时,请重新登录！");
            return false;
        }
        //同意初审
        var obj_state = $(this).parent().siblings().eq(5).text();
        if (obj_state != "立项待审") {
            alert("该项目已经初审完毕！");
            return;
        }
        else {
            var _r = confirm("确定【初审同意】吗");
            if (_r == true) {
                $.get("Handler1.ashx", { Action: "ExpertAuditProject", OperatorID: getCookie("CookieUserID"), ProjectID: $(this).attr("id") }, function(data, textStatus) {
                    if (data != "0") {
                        location.reload();
                        alert("操作成功！");
                    }
                    else {
                        alert("操作失败！");
                    }
                })
            }

        }
    })
})