$(function() {


    var _Command = GetUrlParaValue("Command");
    if (_Command == "System") {
        document.title = "管理制度";
        $("#btnCreate").click(function() { window.location.href = 'BackSystemAndSafetyUpd.aspx?Command=System&CreORUpd=Cre' })
    }
    else {
        document.title = "环境与安全";
        $("#btnCreate").click(function() { window.location.href = 'BackSystemAndSafetyUpd.aspx?Command=Safety&CreORUpd=Cre' })
    }
    $("#backMaster_right1").text(document.title);
    $("#idMyTable .btnDel").click(function() {
        var _r = confirm("确定删除吗？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "DeleteSystemAndSafety", MyID: $(this).attr("id"), Command: _Command }, function(data, textStatus) {
                if (data == "1") {
                    alert("操作成功！");
                    location.reload();
                }
                else {
                    alert("操作失败！");
                }
            })
        }
    })
})