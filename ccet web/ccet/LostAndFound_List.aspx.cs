using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Data;
using System.Linq;
using System.Data.SqlClient;

namespace LabManage
{
    public partial class LostAndFound_List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            createTable();

        }
        protected void createTable()
        {
            for( int i = 0; i < 10; i ++)
            {
                HtmlTableRow htr = new HtmlTableRow();
                for(int j = 0; j < 3; j ++)
                {
                    HtmlTableCell htc = new HtmlTableCell();
                    
                    htr.Cells.Add(htc);
                    htc.Width = "266";
                    htc.Height = "300";
                    htc.InnerHtml = "<img src=\"File/13930812329566731024x1024.jpg\" width=\"250px\" height=\"190px\" style=\"margin-top:-43px;\">" +
                        "<h4>A paragraph</h4>" +
                        "<h4> nidayede</h4>";
                }
                d_table.Rows.Add(htr);
            }
        }

    }

}
