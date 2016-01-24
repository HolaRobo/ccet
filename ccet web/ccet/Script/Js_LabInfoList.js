/* 限制验证码框只能输入数字 */
$(function() {
    document.title = "实验室信息列表";


    $("#txtMaxNO").keyup(function() {
        var tmptxt = $(this).val();
        $(this).val(tmptxt.replace(/\D|^0/g, ''));
    }).bind("paste", function() {
        var tmptxt = $(this).val();
        $(this).val(tmptxt.replace(/\D|^0/g, ''));
    }).css("ime-mode", "disabled");

    $("#idMyTable .btnLabAppointment").click(function() {
        alert($(this).attr("id"));
    })
})
onload = function() {
    //判断登录是否有效
    if (getCookie("CookieUserID") == null) {
        alert("你还没登录或登录已经超时,请重新登录！");
        window.location.href = 'UserLogin.aspx';
        return;
    }
}