$(function() {
    $("#idbtnOK").click(function() {
        //判断登录是否有效
        if (getCookie("CookieUserID") == null) {
            alert("你还没登录或登录已经超时,请重新登录！");
            window.location.href = 'UserLogin.aspx';
            return false;
        }
        var _date = $("#Text2").val();
        if (!CheckDate(_date)) {
            alert("预约日期格式有误,请重新输入！");
            return;
        }
//        var myDate = new Date(); //创建一个日期对象
//        if (ValidtorTime(myDate.toLocaleString(), _date) == false) {
//            alert("预约日期不能是昨天或者更早！");
//            return;
//        }
        var _r = confirm("确定预约吗？");

        var _DateSection = $("input[name='radio1']:checked").val();
        if (_r == true) {
            //验证实验室是否被预定
            $.get("Handler1.ashx", { Action: "ValidateLabAppointment", LabID: GetUrlParaValue("LabID"), Date: _date, DateSection: _DateSection }, function(data, textStatus) {
                if (data != "0") {
                    $.get("Handler1.ashx", { Action: "InsertLabAppointment", LabID: GetUrlParaValue("LabID"), TeacherLeaveMessage: $("#TextArea1").val(),
                        TeacherID: getCookie("CookieUserID"), Date: _date, DateSection: _DateSection
                    }, function(data, textStatus) {
                        if (data != "0") {
                            alert("预约成功!");
                            window.location.href = "MyAppointment.aspx";
                        }
                        else {
                            alert("预约失败!");
                        }
                    })
                }
                else {
                    alert("该实验室已被预约！");
                }
            })
        }
    })
    $("#idMyTable td").each(function() {
        if ($(this).text() == "已预约") {
            $(this).css({ "color": "Red" })
        }
    })
})
function ValidtorTime(Today, AppDate) {
    var d1 = new Date(Today.replace(/-/g, "/")); /*今天*/
    var d2 = new Date(AppDate.replace(/-/g, "/")); /*预约时间*/
    var days = d2.getTime() - d1.getTime();
    var time = parseInt(days / (1000 * 60 * 60 * 24));
    if (time > -1) {

        return true;
    }
    else {
        return false;
    }
}