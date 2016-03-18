using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;

namespace LabManage
{
    public partial class LostAndFound_List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlGenericControl div;
            HtmlGenericControl span;
            TextBox txt;
            Label label1;
            Label label2;
            Label label3;
            Label label4;
            Image loadPhoto;

            for(int i = 0; i < 5; i++)
            {
                div = new HtmlGenericControl();
                div.TagName = "div";
                div.ID = "div" + i.ToString();
                div.Attributes["class"] = "item2";
                div.Attributes.CssStyle.Value = "margin-left: 50px; margin-top:20px; height: 120px; width: 800px;";

                span = new HtmlGenericControl();
                span.ID = "span" + i.ToString();
                span.InnerHtml = "Url Address" + (i + 1).ToString() + ":";

                txt = new TextBox();
                txt.ID = "text" + i.ToString();
                txt.CssClass = "input";

                loadPhoto = new Image();
                //loadPhoto.ImageUrl = "./File";
                loadPhoto.Attributes.CssStyle.Value = "height:120px; width:120px;";
                

                label1 = new Label();
                label1.Text = "名称" + i.ToString();
                label1.CssClass = "";
                label1.Attributes.CssStyle.Value = "position: relative; left: 20px; top: -55px; height:40px;";
                //label1.Font.Size = "16"; 

                label2 = new Label();
                label2.Text = "时间" + i.ToString();
                label2.CssClass = "";
                label2.Attributes.CssStyle.Value = "float:left top: -15px; height:40px;";

                label3 = new Label();
                label3.Text = "时间" + i.ToString();
                label3.CssClass = "";
                label3.Attributes.CssStyle.Value = "left: -20px; top: 25px; height:40px;";

                label4 = new Label();
                label4.Text = "时间" + i.ToString();
                label4.CssClass = "";
                label4.Attributes.CssStyle.Value = "position: relative; left: 20px; top: 65px; height:40px;";
                
                //div.Controls.Add(span);
                //div.Controls.Add(txt);
                div.Controls.Add(loadPhoto);
                div.Controls.Add(label1);
                div.Controls.Add(label2);
                div.Controls.Add(label3);
                div.Controls.Add(label4);
                test1.Controls.Add(div);
            }
        }
    }
}