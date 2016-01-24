$(function() {
    $("#idMyTable .btnDel").click(function() {
        var _r = confirm("确定删除该文件吗？");
        if (_r == true) {
            $.get("Handler1.ashx", { Action: "DeleteResourceFile", FileID: $(this).attr("id") }, function(data, textStatus) {
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

    $("#btnFile").uploadify({// 初始化函数
        'uploader': '../uploadify/uploadify.swf', // flash文件位置，注意路径
        'width': '73px',
        'height': '30',
        'buttonImg': '../img/btnFile_bg.gif',
        'script': "Handler1.ashx?Action=InsertResourceFile", // 后台处理的请求
        'queueID': 'fileTipPro', // 与下面的上传文件列表id对应
        'cancelImg': '../uploadify/cancel.png', // 取消按钮图片
        'queueSizeLimit': 1, // 上传文件的数量
        'fileDesc': 'Word、Excel或PPT文件', // 上传文件类型说明
        'method': 'post', // 如果向后台传输数据，必须是get
        'auto': false, // 是否自动上传
        'multi': false, // 单文件上传
        'sizeLimit': '20000000',
        'buttonText': 'Choose',
        'fileExt': '*.doc;*.doc;*.ppt;', // 控制可上传文件的扩展名，启用本项时需同时声明fileDesc
        'onComplete': function(event, queueID, fileObj, response, data) {
            alert("保存成功！");
        },
        'onError': function(event, queueID, fileObj) {
            alert("保存失败！");

        },
        'onSelect': function(e, queueId, fileObj) {

        $("#Text2").val(fileObj.name);

        }
    });
    $("#btnSave").click(function() {
        //判断登录是否有效
//        if (getCookie("CookieUserID") == null) {
//            alert("你还没登录或登录已经超时,请重新登录！");
//            return false;
//        }
        var _FileTitle = $("#Text1").val();
        if (_FileTitle == "") {
            alert("请输入资源名称！");
            return false;
        }
        var _FileName = $("#Text2").val();
        if (_FileName == "") {
            alert("请选择资源文件！");
            return false;
        }
        var _r = confirm("确定保存吗？");
        if (_r == true) {
            $('#btnFile').uploadifySettings('scriptData', { "Action": "InsertResourceFile",
            "FileTitle": _FileTitle,
            "FileTypeName": $("#Select1").val()
            })
            $('#btnFile').uploadifyUpload();


        }
    })

})