$(function() {
    $("#Text3,#Text4").datepick({ dateFormat: 'yy-mm-dd' });
    document.title = "项目申报-项目申报与管理系统";
    $("#btnBrowse").uploadify({// 初始化函数
        'uploader': '../uploadify/uploadify.swf', // flash文件位置，注意路径
        'width': '80px',
        'height': '36',
        'buttonImg': '../img/btn_bg.gif',
        'script': "Handler1.ashx?Action=InsertProjectInfo", // 后台处理的请求
        'queueID': 'fileTipPro', // 与下面的上传文件列表id对应
        'cancelImg': '../uploadify/cancel.png', // 取消按钮图片
        'queueSizeLimit': 1, // 上传文件的数量
        'fileDesc': 'Word文件', // 上传文件类型说明
        'method': 'post', // 如果向后台传输数据，必须是get
        'auto': false, // 是否自动上传
        'multi': false, // 单文件上传
        'sizeLimit': '20000000',
        'buttonText': 'Choose',
        'fileDesc': '文档', // 出现在上传对话框中的文件类型描述
        'fileExt': '*.doc;', // 控制可上传文件的扩展名，启用本项时需同时声明fileDesc
        'onComplete': function(event, queueID, fileObj, response, data) {
            alert("申报成功！");
        },
        'onError': function(event, queueID, fileObj) {
            alert("申报失败！");

        },
        'onSelect': function(e, queueId, fileObj) {

            $("#Text5").val(fileObj.name);

        }
    });
    $("#btnOK").click(function() {
        //判断登录是否有效
        if (getCookie("CookieUserID") == null) {
            alert("你还没登录或登录已经超时,请重新登录！");
            return false;
        }
        //项目名称
        var _ProjectName = $("#txtProjectName").val();
        if (_ProjectName == "") {
            alert("请输入项目名称！");
            return false;
        }
        //立项日期
        var _SetUpDate = $("#Text3").val();
        if (_SetUpDate == "") {
            alert("请输入立项日期！");
            return false;
        }
        //结题日期
        var _CompleteDate = $("#Text4").val();
        if (_CompleteDate == "") {
            alert("请输入结题日期！");
            return false;
        }
        //申报书
        var _ApplyBook = $("#Text5").val();
        if (_ApplyBook == "") {
            alert("请选择申报书！");
            return false;
        }
        
        
        var _Funds = $("#Text7").val();
        if (_Funds == null) {
            _Funds = 0;
        }
        var _ProjectResultType = $("#Text6").val();
        if (_ProjectResultType == "") {
            _ProjectResultType = "未填";
        }
        var _ProjectFrom = $("#txtProjectForm").val();
        if (_ProjectFrom == "") {
            _ProjectFrom = "未填";
        }
        var _r = confirm("确定申报吗？");
        if (_r == true) {
            $('#btnBrowse').uploadifySettings('scriptData', { "Action": "InsertProjectInfo",
                "UserID": getCookie("CookieUserID"),
                "ProjectName": _ProjectName,
                "SetUpDate": _SetUpDate,
                "CompleteDate": _CompleteDate,
                "Funds": _Funds,
                "ProjectType": $("input[name='myRario1']:checked").val(),
                "ProjectResultType":_ProjectResultType,
                "ProjectFrom": _ProjectFrom
            })
            $('#btnBrowse').uploadifyUpload();


        }
    })
    /*
    var filetitle = $("#txtFileTitle").val();
    $('#idBtnUploadFile').uploadifySettings('scriptData', { 'FileTitle': filetitle })
    $('#idBtnUploadFile').uploadifyUpload();
    */

})

