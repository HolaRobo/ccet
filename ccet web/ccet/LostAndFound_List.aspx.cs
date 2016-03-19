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
            Image loadPhoto;
            Button but1;
            Button but2;
            Button but3;
            Button but4;

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

                but1 = new Button();
                but1.Text = "名 称";
                but1.Font.Bold = true;
                but1.Font.Size = 15;
                but1.Enabled = false;
                but1.CssClass = "btn-warning";
                but1.Attributes.CssStyle.Value = "position: relative; left:20px; top: -44px; text-align:center; height:35px; width: 70px;";

                but2 = new Button();
                but2.Text = "时 间";
                but2.Font.Bold = true;
                but2.Font.Size = 15;
                but2.Enabled = false;
                but2.CssClass = "btn-secondary";
                but2.Attributes.CssStyle.Value = "position: relative; left: -80px; top: -5px; text-align:center; height:35px; width: 70px;";

                but3 = new Button();
                but3.Text = "地 点";
                but3.Font.Bold = true;
                but3.Font.Size = 15;
                but3.Enabled = false;
                but3.CssClass = "btn-secondary";
                but3.Attributes.CssStyle.Value = "position: relative; left: -80px; top: 35px; text-align:center; height:35px; width: 70px;";

                //div.Controls.Add(span);
                //div.Controls.Add(txt);
                div.Controls.Add(loadPhoto);
                
                div.Controls.Add(but1);
                div.Controls.Add(but2);
                div.Controls.Add(but3);
                test1.Controls.Add(div);
            }
        }
    }
}