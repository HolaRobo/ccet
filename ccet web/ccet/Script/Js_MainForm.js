$(function() {
    //document.title = "CCET";
    $("#idnewnotice ul li").eq(0).css({ "color": "Red" });
    $("#idnewnotice ul li").eq(1).css({ "color": "Red" });
    $("#idnewnotice ul li").eq(2).css({ "color": "#FF33CC" });
    $("#idnewnotice ul li").eq(3).css({ "color": "#FF33CC" });


    $("#li_MyAppointment").click(function() {
    window.location.href = 'MyAppointment.aspx';
    })
})