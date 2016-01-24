/*#############################################################
Name: Forms to CSS
Version: 0.7

Author: Utom
URL: http://utombox.com/

Author: Explon
Mail: explon@gmail.com
#############################################################*/

var inputs = document.getElementsByTagName('input');
var textareas = document.getElementsByTagName('textarea');
var selects = document.getElementsByTagName('select');
var isIE = (document.all && window.ActiveXObject && !window.opera) ? true : false;

function $(id)
{
	return document.getElementById(id);
}

function stopBubbling (ev)
{	
	ev.stopPropagation();
}

function rInputs()
{
	for (i = 0; i < inputs.length; i++)
	{
	    rTextPassword(i);
	}
}


function rTextPassword(i)
{
	inputs[i].className = 'type_text';	
	inputs[i].onblur = function()
	{
		this.className = 'type_text';
	}
	inputs[i].onfocus = function()
	{
		this.className = 'type_text_focus';
	}
	inputs[i].onmouseover = function()
	{	
		if (this.className != 'type_text_focus')
		{
			this.className = 'type_text_hover';
		}
	}
	inputs[i].onmouseout =  function()
	{	
		if (this.className != 'type_text_focus')
		{
			this.className = 'type_text';
		}
	}
}



function rOptions(i, name)
{
	var options = selects[i].getElementsByTagName('option');
	var options_ul = 'options_' + name;
	for (n=0;n<selects[i].options.length;n++)
	{	
		option_li = document.createElement('li');
			option_li.style.cursor = 'pointer';
			option_li.className = 'open';
		$(options_ul).appendChild(option_li);
		option_text = document.createTextNode(selects[i].options[n].text);
		option_li.appendChild(option_text);
		option_selected = selects[i].options[n].selected;
		if (option_selected)
		{
			option_li.className = 'open_selected';
			option_li.id = 'selected_' + name;
			$('select_info_' + name).appendChild(document.createTextNode(option_li.innerHTML));
		}		
		option_li.onmouseover = function()
		{
			this.className = 'open_hover';
		}
		option_li.onmouseout = function()
		{
			if (this.id == 'selected_' + name)
			{
				this.className = 'open_selected';
			}
			else
			{
				this.className = 'open';
			}
		} 
	
		option_li.onclick = new Function("clickOptions(" + i + "," + n + ",'" + selects[i].name + "')");
	}
}




function clickOptions(i, n, name)
{		
	var li = $('options_' + name).getElementsByTagName('li');
	$('selected_' + name).className = 'open';
	$('selected_' + name).id = '';
	li[n].id = 'selected_' + name;
	li[n].className = 'open_hover';
	$('select_' + name).removeChild($('select_info_' + name));
	select_info = document.createElement('div');
		select_info.id = 'select_info_' + name;
		select_info.className = 'tag_select';
		select_info.style.cursor = 'pointer';
	$('options_' + name).parentNode.insertBefore(select_info,$('options_' + name));
	mouseSelects(name);
	$('select_info_' + name).appendChild(document.createTextNode(li[n].innerHTML));
	$( 'options_' + name ).style.display = 'none' ;
	$( 'select_info_' + name ).className = 'tag_select';
	selects[i].options[n].selected = 'selected';

}

window.onload = function(e)
{
	bodyclick = document.getElementsByTagName('body').item(0);
	rInputs();
	rTextareas();
	rSelects();
	bodyclick.onclick = function()
	{
		for (i = 0; i < selects.length; i++)
		{	
			$('select_info_' + selects[i].name).className = 'tag_select';
			$('options_' + selects[i].name).style.display = 'none';
		}
		
		checkInputs();
	}
}



function checkAllCheckboxs(form, prefix, stats)
{	
	for (var i = 0; i < form.elements.length; i++)
	{
		var e = form.elements[i];
		
		if (e.name && e.type == 'checkbox' && (!prefix || (prefix && e.name.match(prefix))))
		{
			e.checked = stats;
		}
	}
}