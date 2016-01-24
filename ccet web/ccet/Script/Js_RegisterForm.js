/// <reference path="jquery-1.4.4.js" />


$(function() {
document.title="用户注册-项目申报与管理系统";

    $("#btnStuRegister").click(
	function() {
	    var _UserName = $("#Text6").val();
	    if (_UserName == "") {
	        alert('请输入用户名(登录名)');
	        return;
	    }

	    //用户密码
	    var _UserPwd = $("#Password3").val();
	    if (_UserPwd == "") {
	        _UserPwd('请输入密码');
	        return;
	    }

	    //确认密码
	    var _UserOKPwd = $("#Password4").val();
	    if (_UserOKPwd == "") {
	        alert('请再次确认密码');
	        return;
	    }
	    if (_UserPwd != _UserOKPwd) {
	        alert('你两次输入的密码不一致,请重新输入！');
	        return;
	    }
	    
	    
	      //真实名字
	    var _RealName = $("#Text2").val();
	    if (_RealName == "") {
	        alert('请输入您的真实名字');
	        return;
	    }
	    
	    //身份证号码
	    var _IdentityCard = $("#Text1").val();
	    if (_IdentityCard == "") {
	        alert('请输入身份证号码');
	        return;
	    }
	    //身份证号码有效性检测
	    if (isIdCardNo(_IdentityCard) == false) {
	        return;
	    }
	    //出生日期
	    var _birthday=$("Text8").val();
	    if(_birthday==""){
	    alert("请输入出生日期！");
	    return;
	    }
	    //联系手机
	    var _LinkPhone = $("#Text12").val();
	    if (_LinkPhone == "") {
	        alert('请输入联系手机');
	        return;
	    }

	    var _UserMail = $("#Text11").val();
	    if(_UserMail!="")
	    {
	    var myReg = /^[_a-z0-9.]+@([_a-z0-9]+\.)+[a-z0-9]{2,3}$/i;
	    // 邮箱格式错误
	    if (!myReg.test(_UserMail)) {
	        alert('邮箱格式错误');

	        return;
	    }}
	
	    var _r = confirm("确定注册吗？");
	    if (_r == true) {
	        /*前台验证通过 */
	        $.get("Handler1.ashx", { Action: "InsertDeclarationUserInfo",
	            UserName: _UserName,
	            UserPwd: _UserPwd,
	            RealName:_RealName,
	            IdentityCard: _IdentityCard,
	            Sex:$("#Select1").find("option:selected").text(),
	            BirthDay: $("#Text8").val(),
	            EducationBack: $("#Select3").find("option:selected").text(),
	            Phone: $("#Text12").val(),
	            LinkAddress: $("#Text7").val(),
	            Email: $("#Text11").val(),
	        }, function(data, textStatus) {
	            if (data == "1") {
	                alert('注册成功');
	            }
	            else {
	                alert('注册失败');

	            }

	        })
	    }

	})



})

// TextBox里内容的实际长度 数字和字母长度为1 汉字为2
function getstrLen(Elenemtid) {
    var val = $("#" + Elenemtid).val();
    return val.replace(/[^\x00-\xff]/g, "**").length;

}

function isIdCardNo(num) {
    num = num.toUpperCase();           //身份证号码为15位或者18位，15位时全为数字，18位前17位为数字，最后一位是校验位，可能为数字或字符X。        
    if (!(/(^\d{15}$)|(^\d{17}([0-9]|X)$)/.test(num))) {
        alert('输入的身份证号长度不对，或者号码不符合规定！\n15位号码应全为数字，18位号码末位可以为数字或X。');
        return false;
    } //校验位按照ISO 7064:1983.MOD 11-2的规定生成，X可以认为是数字10。 
    //下面分别分析出生日期和校验位 
    var len, re; len = num.length; if (len == 15) {
        re = new RegExp(/^(\d{6})(\d{2})(\d{2})(\d{2})(\d{3})$/);
        var arrSplit = num.match(re);  //检查生日日期是否正确
        var dtmBirth = new Date('19' + arrSplit[2] + '/' + arrSplit[3] + '/' + arrSplit[4]);
        var bGoodDay; bGoodDay = (dtmBirth.getYear() == Number(arrSplit[2])) && ((dtmBirth.getMonth() + 1) == Number(arrSplit[3])) && (dtmBirth.getDate() == Number(arrSplit[4]));
        if (!bGoodDay) {
            alert('输入的身份证号里出生日期不对！');
            return false;
        } else { //将15位身份证转成18位 //校验位按照ISO 7064:1983.MOD 11-2的规定生成，X可以认为是数字10。        
            var arrInt = new Array(7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2);
            var arrCh = new Array('1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2');
            var nTemp = 0, i;
            num = num.substr(0, 6) + '19' + num.substr(6, num.length - 6);
            for (i = 0; i < 17; i++) {
                nTemp += num.substr(i, 1) * arrInt[i];
            }
            num += arrCh[nTemp % 11];
            return true;
        }
    }
    if (len == 18) {
        re = new RegExp(/^(\d{6})(\d{4})(\d{2})(\d{2})(\d{3})([0-9]|X)$/);
        var arrSplit = num.match(re);  //检查生日日期是否正确 
        var dtmBirth = new Date(arrSplit[2] + "/" + arrSplit[3] + "/" + arrSplit[4]);
        var bGoodDay; bGoodDay = (dtmBirth.getFullYear() == Number(arrSplit[2])) && ((dtmBirth.getMonth() + 1) == Number(arrSplit[3])) && (dtmBirth.getDate() == Number(arrSplit[4]));
        if (!bGoodDay) {
            alert(dtmBirth.getYear());
            alert(arrSplit[2]);
            alert('输入的身份证号里出生日期不对！');
            return false;
        }
        else { //检验18位身份证的校验码是否正确。 //校验位按照ISO 7064:1983.MOD 11-2的规定生成，X可以认为是数字10。 
            var valnum;
            var arrInt = new Array(7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2);
            var arrCh = new Array('1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2');
            var nTemp = 0, i;
            for (i = 0; i < 17; i++) {
                nTemp += num.substr(i, 1) * arrInt[i];
            }
            valnum = arrCh[nTemp % 11];
            if (valnum != num.substr(17, 1)) {
                alert('18位身份证的校验码不正确！应该为：' + valnum);
                return false;
            }
            return true;
        }
    } return false;

}