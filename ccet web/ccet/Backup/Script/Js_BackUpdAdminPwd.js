$(function() {


    $("#btnUpd").click(function() {

        //判断登录是否有效
        if (getCookie("CookieUserID") == null) {
            alert("你还没登录或登录已经超时,请重新登录！");
            return false;
        }

        //旧密码密码
        var _OldPwd = $("#Password1").val();
        if (_OldPwd == "") {
            alert('请输入旧密码');
            return;
        }
        //新密码
        var _NewPwd = $("#Text2").val();
        if (_NewPwd == "") {
            alert('请输入新密码');
            return;
        }

        //确认密码
        var _OKPwd = $("#Text3").val();
        if (_OKPwd == "") {
            alert('请再次确认新密码');
            return;
        }
        if (_NewPwd != _OKPwd) {
            alert('你两次输入的密码不一致,请重新输入！');
            return;
        }
        var _r = confirm("确定修改吗？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "UpdateTeacherAdminPwd",
                TeacherName: getCookie("CookieUserName"),
                OldPwd: _OldPwd,
                NewPwd: _NewPwd,
                Identity: 'Admin'
            }, function(data, textStatus) {
                if (data == "-1") {
                    alert('旧密码错误');

                }
                else {
                    if (data != "0") {
                        alert("恭喜你,修改成功！");
                    }
                    else {
                        alert("对不起,修改失败！");
                    }

                }

            })
        }

    })
})