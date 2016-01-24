$(function() {

    $("#idbtnOK").click(function() {
        if ($("#ctl00_ContentPlaceHolder1_Label6").text() == "未审批") {
            var _r = confirm("确定审批吗");
            if (_r == true) {
                $.get("Handler1.ashx", { Action: "AccraditationAppointment", AppointmentID: GetUrlParaValue("AppointmentID"),
                    AdminAllow: $("input[name='radio1']:checked").val(), AdminReason: $("#TextArea1").val()
                }, function(data, textStatus) {
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
        else {
            alert("该预约已经审批过,不能再进行操作！");
        }
    })


    $("#btndel").click(function() {
        var _r = confirm("确定删除该预约吗");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "DeleteLabAppointment", AppointmentID: GetUrlParaValue("AppointmentID")
            }, function(data, textStatus) {
            if (data != "0") {
                alert("操作成功！");
                window.location.href = 'BackTeacherAppointment.aspx';
            }
                else { alert("操作失败！") }
            })
        }
    })




})