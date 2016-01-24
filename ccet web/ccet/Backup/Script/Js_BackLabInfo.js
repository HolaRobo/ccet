var _labID = 0;
$(function() {
    $("#idMyTable .btnDel").click(function() {
        var _r = confirm("确定删除吗？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "BackCUDLabInfo", CUD: 'D', LabID: $(this).attr("id"), LabName: '', LabTypeID: 0, MaxNO: 0 }, function(data, textStatus) {
                if (data == "1") {
                    alert("操作成功！");
                    window.location = window.location
                }
                else {
                    alert("操作失败！");
                }
            })
        }
    })

    $("#btnCreate").click(function() {
        $("#BackLabInfo_bottom").slideDown('slow');
    })

    $("#btnSave").click(function() {
        var _labName = $("#Text1").val();
        if (_labName == "") {
            alert("请输入实验室名称");
            return;
        }
        var _maxNo = $("#Text2").val();
        if (_maxNo == "") {
            alert("请输入最大容纳人数");
            return;
        }
        if (!IsNum(_maxNo)) {
            alert("最大容纳人数无效,请重新输入");
            return;
        }
        var _r = confirm("确定保存吗？");
        if (_r == true) {

            var _cud = 'C'; //默认为新建实验室操作
            if (_labID != 0) { _cud = "U"; } //这里修改为修改实验室操作
            $.get("Handler1.ashx", { Action: "BackCUDLabInfo", CUD: _cud, LabID: _labID, LabName: _labName, LabTypeID: $("#ctl00_ContentPlaceHolder1_DropDownList1").val(), MaxNO: _maxNo }, function(data, textStatus) {
                if (data == "1") {
                    alert("操作成功！");
                    window.location = window.location
                }
                else {
                    alert("操作失败！");
                }
            })
        }
    })
    $("#idMyTable .btnUpd").click(function() {
        var obj_jquery = $(this).parent().parent();
        $("#Text1").val(obj_jquery.find("td").eq(0).text());
        $("#Text2").val(obj_jquery.find("td").eq(2).text());
        _labID = $(this).attr("id");
        var obj_labType = obj_jquery.find("td").eq(1).text();
        var count = $("#ctl00_ContentPlaceHolder1_DropDownList1 option").length;
        for (var i = 0; i < count; i++) {
            if ($("#ctl00_ContentPlaceHolder1_DropDownList1").get(0).options[i].text == obj_labType) {
                $("#ctl00_ContentPlaceHolder1_DropDownList1").get(0).options[i].selected = true;

                break;
            }
        }
        $("#BackLabInfo_bottom").slideDown('slow');
    })

})
//判断是否为数字
function IsNum(s) {
    if (s != null && s != "") {
        return !isNaN(s);
    }
    return false;
}