$(function() {


    $("#btnTeacher").click(function() {
        var _TeacherrName = $("#Text1").val();
        if (_TeacherrName == "") {
            alert('请输入教师名称)');
            return;
        }

        //用户密码
        var _TeacherrPwd = $("#Password1").val();
        if (_TeacherrPwd == "") {
            alert('请输入旧密码');
            return;
        }
        //用户密码
        var _TeacherrPwd_New = $("#Text2").val();
        if (_TeacherrPwd_New == "") {
            alert('请输入新密码');
            return;
        }

        //确认密码
        var _TeacherrOKPwd = $("#Text3").val();
        if (_TeacherrOKPwd == "") {
            alert('请再次确认新密码');
            return;
        }
        if (_TeacherrPwd_New != _TeacherrOKPwd) {
            alert('你两次输入的密码不一致,请重新输入！');
            return;
        }

        var _r = confirm("确定修改吗？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "UpdateTeacherAdminPwd",
                TeacherName: _TeacherrName,
                OldPwd: _TeacherrPwd,
                NewPwd: _TeacherrOKPwd,
                Identity:"Teacher"
            }, function(data, textStatus) {
                if (data == "-1") {
                    alert('旧密码错误');
                   
                }
                else {
                    if (data != "0") {
                        alert("恭喜你,修改成功！");
                        location.href = "MainForm.aspx";
                    }
                    else {
                        alert("对不起,修改失败！");
                    }

                }

            })
        }

    })
})