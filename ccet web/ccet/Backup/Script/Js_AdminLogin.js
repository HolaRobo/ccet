$(function() {


    $("#btnLogin").click(function() {
        //用户名
        var _UserName = $("#account_name").val();
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
        $.get("Handler1.ashx", { Action: "LoginValidate", UserName: _UserName, UserPwd: _UserPwd, Identity: "Admin" }, function(data, textStatus) {
            if (data != "0") {
                alert("登录成功！");
                window.location.href = "MainForm.aspx";
            }
            else {
                alert("用户名或密码错误,登录失败！");
            }
        })
    })


})


