$(function() {
 
    if (GetUrlParaValue("CreateORUpdate") == "Update") {
        $("#CreateNoticeNews_top").text("修改新闻公告");
        document.title = "修改新闻公告";
        $("#backMaster_right1").text(document.title);
        $("#txtTitle").val(decodeURI(GetUrlParaValue("Title")));
        $.get("Handler1.ashx", { Action: "SearchNewsInfo", NewsID: GetUrlParaValue("NewsID") }, function(data, textStatus) {
            KE.html("TextArea1", data)
        })
        //绑定按钮为修改功能
        $("#btnCreate").click(function() {
            //判断登录是否有效
            if (getCookie("CookieUserID") == null) {
                alert("你还没登录或登录已经超时,请重新登录！");
                return false;
            }
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
        })
    }
    else {
        //绑定按钮为新增功能
        $("#btnCreate").click(function() {
            //判断登录是否有效
            if (getCookie("CookieUserID") == null) {
                alert("你还没登录或登录已经超时,请重新登录！");
                return false;
            }
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
                alert("内容长度太短,请完善" + obj_content.length);
                return;
            }
            var _r = confirm("确定创建吗？");
            if (_r == true) {
                $.get("Handler1.ashx", { Action: "InsertNoticeNews", NewsTitle: obj_Title, NewsContent: obj_content, AdminID: getCookie("CookieUserID") }, function(data, textStatus) {
                    if (data != "0") {
                        alert("操作成功！");
                    }
                    else {
                        alert("操作失败！");
                    }
                })
            }
        })
    }
})
