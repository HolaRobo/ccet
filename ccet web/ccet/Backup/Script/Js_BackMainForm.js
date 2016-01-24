$(function(){
	$("#btnMainLogin").click(function(){
		//用户名
		var UserNameMain=$("#txtUserNameMain").val();
		if(UserNameMain=="")
		{
			ymPrompt.alert({
				message:'请输入<strong style=color:red>用户名</strong>!',
				height:140
			})
			return ;
		}
		//密码
		var UserPwdMain=$("#txtUserPwdMain").val();
		if(UserPwdMain=="")
		{
			ymPrompt.alert({
				message:'请输入<strong style=color:red>密码</strong>!',
				height:140
			})
			return ;
		}
		
		//用户名长度太短
		if(getstrLen("txtUserNameMain")<4)
		{
		   ymPrompt.errorInfo({message:'用户名错误,登录失败!',height:140})
			return ;
		}
		
			//密码长度太短
		if(UserPwdMain.length<6)
		{
		   ymPrompt.errorInfo({message:'用户密码,登录失败!',height:140})
			return ;
		}
		/*前台验证通过 转入后台登录验证*/
		$.get("Handler1.ashx",{Action:"LoginValidate",UserName:UserNameMain,UserPwd:UserPwdMain},function(data,textStatus){
		alert(data);
		})
		})
		
		
		$("#backMain_a1").click(function(){
		 $("#idright_top").text('新增基金信息');
		 var _src= $("#idmainiframe").attr("src");
		   setiframeSrc("idbackMainiframe","BackFundInfoAdd.aspx");
		})
		
		$("#backMain_a2").click(function(){
		 $("#idright_top").text('修改和删除基金信息');
		 var _src= $("#idmainiframe").attr("src");
		   setiframeSrc("idbackMainiframe","BackFundInfo.aspx");
		})
		$("#backMain_a3").click(function(){
		 $("#idright_top").text('用户信息管理');
		 var _src= $("#idmainiframe").attr("src");
		   setiframeSrc("idbackMainiframe","BackUserInfo.aspx");
		})
		$("#backMain_a4").click(function(){
		 $("#idright_top").text('用户收藏情况');
		 var _src= $("#idmainiframe").attr("src");
		   setiframeSrc("idbackMainiframe","BackFundCollect.aspx");
		})
		$("#backMain_a5").click(function(){
		 $("#idright_top").text('管理员信息管理');
		 var _src= $("#idmainiframe").attr("src");
		   setiframeSrc("idbackMainiframe","BackAdminInfo.aspx");
		})
	})
function setiframeSrc(iframeID,page)
{
var _src=$("#"+iframeID).attr("src");
if(_src!=page)
{
$("#"+iframeID).attr("src",page);
}
}	
	
	// TextBox里内容的实际长度 数字和字母长度为1 汉字为2
 function getstrLen(Elenemtid)
{
	var val=$("#"+Elenemtid).val();
	return val.replace(/[^\x00-\xff]/g,"**").length;

}