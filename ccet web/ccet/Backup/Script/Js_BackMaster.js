//获取Cookie的Values
function getCookie(name) {
    var arr = document.cookie.match(new RegExp("(^| )" + name + "=([^;]*)(;|$)"));
    if (arr != null) return decodeURI(arr[2]); return null
}

//删除名称为name的Cookie  
function Deletecookie(name) {
    var exp = new Date();
    exp.setTime(exp.getTime() - 1);
    var cval = getCookie(name);
    document.cookie = name + "=" + cval + "; expires=" + exp.toGMTString();
}


$(function() {
    var _Identity = getCookie("CookieIdentity");
    if (_Identity != null) {
        switch (_Identity) {
            //学生登录          
            case "Student":
                $("#master_li2").hide(); //我的信息(企业)
                $("#master_li4").hide(); //学生应聘情况
                $("#master_li5").hide(); //学生信息管理
                $("#master_li7").hide(); //我司应聘情况
                $("#id_nav").html("学生：" + getCookie("CookieUserName") + ",欢迎您！");
                break;
            //企业登录
            case "Enterprise":
                $("#master_li1").hide(); //我的信息(学生)
                $("#master_li4").hide(); //学生应聘情况
                $("#master_li6").hide(); //企业信息管理
                $("#master_li8").hide(); //我的投档情况
                $("#id_nav").html("企业：" + getCookie("CookieUserName") + ",欢迎您！");
                break;
            //管理员登录
            case "Admin":
                $("#master_li1").hide(); //我的信息(学生)
                $("#master_li2").hide(); //我的信息(企业)
                $("#master_li7").hide(); //我司应聘情况
                $("#master_li8").hide(); //我的投档情况
                $("#id_nav").html("管理员：" + getCookie("CookieUserName") + ",欢迎您！");
                break;
        }
    }
    else {
        $("#id_nav").html("游客,欢迎您！");
    }

    $("#btnExit").click(function() {
        var _r = confirm("确定退出吗？");
        if (_r == true) {
            Deletecookie("CookieUserID");
            Deletecookie("CookieUserName");
            Deletecookie("CookieIdentity");
            window.location.href = "Login_User.aspx";
        }
    })

    $("#master_content_left ul li").click(function() {
      $("#right-top").html($(this).text());
    })
})