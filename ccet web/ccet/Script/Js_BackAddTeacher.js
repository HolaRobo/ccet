$(function() {

    if (GetUrlParaValue("TeacherName") != "") {
        $("#td_title").text("修改教师信息");
        $("#Text1").val(decodeURI(GetUrlParaValue("TeacherName")));
    }
    $("#btnTeacher").click(function() {
        var _TeacherrName = $("#Text1").val();
        if (_TeacherrName == "") {
            alert('请输入教师名称)');
            return;
        }

        //用户密码
        var _TeacherrPwd = $("#Text2").val();
        if (_TeacherrPwd == "") {
            _TeacherrPwd('请输入密码');
            return;
        }

        //确认密码
        var _TeacherrOKPwd = $("#Text3").val();
        if (_TeacherrOKPwd == "") {
            alert('请再次确认密码');
            return;
        }
        if (_TeacherrPwd != _TeacherrOKPwd) {
            alert('你两次输入的密码不一致,请重新输入！');
            return;
        }
        var _TeacherID = 0;
        var _CreateORUpdate = "Create";
        if (GetUrlParaValue("TeacherID") != "") {
            _TeacherID = GetUrlParaValue("TeacherID");
        }
        if (_TeacherID != 0) {
            _CreateORUpdate = "Update";
        }
        if (_CreateORUpdate == "Create") {
            //检测教师名称是否存在
            $.get("Handler1.ashx", { Action: "ValidateTeacherNameExist",
                UserName: _TeacherrName
            }, function(data, textStatus) {
                if (data == "1") {
                    alert('该教师名已存在,不能注册！');

                }
                else {
                    var _r = confirm("确定保存吗？");

                    if (_r == true) {
                        /*前台验证通过 */
                        $.get("Handler1.ashx", { Action: "InsertOrUpdateTeacher",
                            TeacherID: _TeacherID,
                            TeacherName: _TeacherrName,
                            TeacherPwd: _TeacherrPwd,
                            CreateORUpdate: _CreateORUpdate
                        }, function(data, textStatus) {
                            if (data == "1") {
                                alert('保存成功');
                            }
                            else {
                                alert('保存失败');

                            }

                        })
                    }
                }

            })
        }
        else {
            var _r = confirm("确定保存吗？");

            if (_r == true) {
                /*前台验证通过 */
                $.get("Handler1.ashx", { Action: "InsertOrUpdateTeacher",
                    TeacherID: _TeacherID,
                    TeacherName: _TeacherrName,
                    TeacherPwd: _TeacherrPwd,
                    CreateORUpdate: _CreateORUpdate
                }, function(data, textStatus) {
                    if (data == "1") {
                        alert('保存成功');
                    }
                    else {
                        alert('保存失败');

                    }

                })
            }
        }

    })
})