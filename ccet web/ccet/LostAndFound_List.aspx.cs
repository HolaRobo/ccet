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

            for(int i = 0; i < 5; i++)
            {
                div = new HtmlGenericControl();
                div.TagName = "div";
                div.ID = "div" + i.ToString();
                div.Attributes["class"] = "item2";

                span = new HtmlGenericControl();
                span.ID = "span" + i.ToString();
                span.InnerHtml = "Url Address" + (i + 1).ToString() + ":";

                txt = new TextBox();
                txt.ID = "text" + i.ToString();
                txt.CssClass = "input";

                div.Controls.Add(span);
                div.Controls.Add(txt);
                test1.Controls.Add(div);
            }
        }
    }
}