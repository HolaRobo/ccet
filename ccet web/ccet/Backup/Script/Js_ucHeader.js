$(function() {

 



    $("#tdexit").click(function() {
        var _r = confirm("确定退出吗？");
        if (_r == true) {
            Deletecookie("CookieUserID");
            Deletecookie("CookieUserName");
            Deletecookie("CookieIdentity");
            window.location.href = "MainForm.aspx";
        }
    })

})