var _labTypeID = 0;
$(function() {
    $("#idMyTable .btnDel").click(function() {
        var _r = confirm("该类型被删除后,该类型的实验室也将被同时删除,是否删除？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "BackOpearLabType",  LabTypeID:$(this).attr("id"),  LabTypeName:'',  Command:"Delete"}, function(data, textStatus) {
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

    $("#btnSave").click(function() {
        var _labTypeName = $("#Text2").val();
        if (_labTypeName == "") {
            alert("请输入实验室类型名称");
            return;
        }
        var _command="Insert";
        if(_labTypeID!=0)
        {
        _command="Update";
        }
        var _r = confirm("确定保存吗？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "BackOpearLabType",  LabTypeID:_labTypeID,  LabTypeName:_labTypeName,  Command:_command}, function(data, textStatus) {
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
    //编辑
    $("#idMyTable .btnUpd").click(function() {
        var obj_jquery = $(this).parent().parent();
        $("#Text2").val(obj_jquery.find("td").eq(0).text());
        _labTypeID = $(this).attr("id");
    })

})
