$(function() {
    var _Command = GetUrlParaValue("Command");
    if (_Command != "") {
        switch (_Command) {
            case "CenterAbstruct":
                $("#BackPublicPage_top").text("中心简介");
                document.title = "编辑中心简介";
                break;
            case "CenterTeam":
                $("#BackPublicPage_top").text("中心队伍");
                document.title = "编辑中心队伍";
                break;
            case "DevelopPlan":
                $("#BackPublicPage_top").text("发展规划");
                document.title = "编辑发展规划";
                break;
            case "StudentResult":
                $("#BackPublicPage_top").text("学生学习成果");
                document.title = "编辑学生学习成果";
                break;
            case "TeacherResult":
                $("#BackPublicPage_top").text("实验教学成果");
                document.title = "编辑实验教学成果";
                break;
        }
        $("#backMaster_right1").text(document.title);
        $.get("Handler1.ashx", { Action: "SearchPublicInfo", Command: _Command }, function(data, textStatus) {
            KE.html("TextArea1", data)
        })

        //绑定
        $("#btnSave").click(function() {
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
            $.get("Handler1.ashx", { Action: "UpdatePublicInfo", Command:_Command, Content: obj_content }, function(data, textStatus) {
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
