$(function() {
    $("#idbtnLogin").click(function() {
        //用户名
        var _UserName = $("#username").val();
        if (_UserName == "") {
            alert("请输入用户名！");
            return;
        }
        //密码
        var _UserPwd = $("#password").val();
        if (_UserPwd == "") {
            alert("请输入密码！");
            return;
        }

        //是否教师
        var _IsTeacher = $("input[name='identity']:checked").val();
        $.get("Handler1.ashx", { Action: "LoginValidate", UserName: _UserName, UserPwd: _UserPwd, Identity: _IsTeacher }, function(data, textStatus) {
            if (data != "0") {
                alert("登录成功！");
                if (_IsTeacher == "teacher") {

                    window.location.href = " MyAppointment.aspx";
                }
                else {
                    window.location.href = "CreateNoticeNews.aspx";
                }
            }
            else {
                alert("用户名或密码错误,登录失败！");
            }
        })
    })


})


