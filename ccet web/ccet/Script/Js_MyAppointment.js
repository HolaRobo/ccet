
onload = function() {
if (getCookie("CookieUserID") == null) {
    alert("你需要登录才能查看预约情况");
    window.location.href = 'UserLogin.aspx';
}
}