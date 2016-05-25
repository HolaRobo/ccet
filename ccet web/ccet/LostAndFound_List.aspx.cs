using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;

namespace LabManage
{
    public partial class LostAndFound_List : System.Web.UI.Page
    {
        dbDataContext db = new dbDataContext();
        //var b = db.LostAndFound_Admin;
        //int c;
        //bool flag = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                createTable();
            }

        }

        
        protected void createTable()
        {
            var b = db.LostAndFound_Admin;
            var a = from t in b select t;
            int c = b.Count();
            int count = 0;
            string[] nameList = new string[c];
            string[] dateList = new string[c];
            string[] desList = new string[c];
            string[] imageList = new string[c];
            string[] roomList = new string[c];
            
            foreach (var d in a)
            {
                
                var name = d.Name;
                nameList[count] = name;
                var room = d.Room;
                roomList[count] = room;
                var lostDate = d.LostTime;
                dateList[count] = lostDate.ToString("yyyy-MM-dd");
                var des = d.Description;
                desList[count] = des;
                var image = d.ImageName;
                imageList[count] = image;
                count++;
            }

            int row = count / 3 ;
            if (count % 3 > 0) row++;
            //Response.Write(row.ToString()+"   "+count.ToString());
            int cnt = 0;

            for ( int i = 0; i < row; i ++)
            {
                HtmlTableRow htr = new HtmlTableRow();
                for (int j = 0; j < 3; j++)
                {
                    HtmlTableCell htc = new HtmlTableCell();

                    htr.Cells.Add(htc);
                    htc.Width = "266";
                    htc.Height = "300";

                    htc.InnerHtml = "<img src=\"File/" + imageList[i * 3 + j] + "\" width=\"250px\" height=\"190px\" style=\"margin-top:10px;\">" +
                           "<h5>" + "名称："+nameList[i * 3 + j] + "</h5>" +
                           "<h5>" + "机房："+roomList[i * 3 + j] + "</h5>" +
                           "<h5>" + "日期："+dateList[i * 3 + j] + "</h5>" +
                           "<h5>" + "描述："+desList[i * 3 + j] + "</h5>";
                           ;
                    cnt++;
                    if (cnt == count)
                        break;
                }
                d_table.Rows.Add(htr);
            }
        }
        */

        protected void jifang(object sender, EventArgs e)
        {
            
            bool type = false;
            var tb = db.LostAndFound_Admin;
            var tb1 = db.LostAndFound_Student;
            var a = from t in tb select t;
            var aa = from t in tb1 select t;
            int num = tb.Count();
            string text = (sender as Button).Text;
            if (text == "第一机房")
                a = from t in tb where t.Room == "第一机房" select t;
            else if (text == "第二机房")
                a = from t in tb where t.Room == "第二机房" select t;
            else if (text == "第三机房")
                a = from t in tb where t.Room == "第三机房" select t;
            else if (text == "第四机房")
                a = from t in tb where t.Room == "第四机房" select t;
            else if (text == "第五机房")
                a = from t in tb where t.Room == "第五机房" select t;
            else if (text == "第六机房")
                a = from t in tb where t.Room == "第六机房" select t;
            else if (text == "第七机房")
                a = from t in tb where t.Room == "第七机房" select t;
            else if (text == "电子产品")
                a = from t in tb where t.Type == "电子产品" select t;
            else if (text == "书籍资料")
                a = from t in tb where t.Type == "书籍资料" select t;
            else if (text == "其他")
                a = from t in tb where t.Type == "其他" select t;
            else if (text == "已被领取")
                type = true;

            int c = tb.Count();
            int cc = tb1.Count();
            if (c < cc) c = cc;
            int count = 0;
            string[] nameList = new string[c];
            string[] dateList = new string[c];
            string[] desList = new string[c];
            string[] imageList = new string[c];
            string[] roomList = new string[c];

            if (!type)
            {
                foreach (var d in a)
                {

                    var name = d.Name;
                    nameList[count] = name;
                    var room = d.Room;
                    roomList[count] = room;
                    var lostDate = d.LostTime;
                    dateList[count] = lostDate.ToString("yyyy-MM-dd");
                    var des = d.Description;
                    desList[count] = des;
                    var image = d.ImageName;
                    imageList[count] = image;
                    count++;
                }
            }
            else
            {
                
                foreach (var d in aa)
                {

                    var name = d.Name;
                    nameList[count] = name;
                    var room = d.Room;
                    roomList[count] = room;
                    var lostDate = d.LostTime;
                    dateList[count] = lostDate.ToString("yyyy-MM-dd");
                    var des = d.Description;
                    desList[count] = des;
                    var image = d.ImageName;
                    imageList[count] = image;
                    count++;
                }
            }

            int row = count / 3;
            if (count % 3 > 0) row++;
            //Response.Write(row.ToString()+"   "+count.ToString());
            int cnt = 0;

            for (int i = 0; i < row; i++)
            {
                HtmlTableRow htr = new HtmlTableRow();
                for (int j = 0; j < 3; j++)
                {
                    HtmlTableCell htc = new HtmlTableCell();

                    htr.Cells.Add(htc);
                    htc.Width = "266";
                    htc.Height = "300";

                    htc.InnerHtml = "<img src=\"File/" + imageList[i * 3 + j] + "\" width=\"250px\" height=\"190px\" style=\"margin-top:10px;\">" +
                           "<h5>" + "名称：" + nameList[i * 3 + j] + "</h5>" +
                           "<h5>" + "机房：" + roomList[i * 3 + j] + "</h5>" +
                           "<h5>" + "日期：" + dateList[i * 3 + j] + "</h5>" +
                           "<h5>" + "描述：" + desList[i * 3 + j] + "</h5>";
                    ;
                    cnt++;
                    if (cnt == count)
                        break;
                }
                d_table.Rows.Add(htr);
            }
        }

        /*

        protected void digital(object sender, EventArgs e)
        {
            var tb = db.LostAndFound_Admin;
            var a = from t in tb where t.Type=="电子产品" select t;
            //c = tb.Count();
            createTable();
        }

        protected void book(object sender, EventArgs e)
        {
            var tb = db.LostAndFound_Admin;
            var a = from t in tb where t.Type == "书籍资料" select t;
            //c = tb.Count();
            createTable();
        }

        protected void other(object sender, EventArgs e)
        {
            var tb = db.LostAndFound_Admin;
            var a = from t in tb where t.Type == "其他" select t;
            //c = tb.Count();
            createTable();
        }

        protected void hasBeenConfirmed(object sender, EventArgs e)
        {
            var tb = db.LostAndFound_Student;
            var ele = from t in tb select t;
        }

        protected void first(object sender, EventArgs e)
        {
            var b = db.LostAndFound_Admin;
            var a = from t in b where t.Room == "第一机房" select t;
        }

        protected void second(object sender, EventArgs e)
        {
            var tb = db.LostAndFound_Admin;
            var a = from t in tb where t.Room == "第二机房" select t;
        }

        protected void there(object sender, EventArgs e)
        {
            var tb = db.LostAndFound_Admin;
            var a = from t in tb where t.Room == "第三机房" select t;
        }

        protected void four(object sender, EventArgs e)
        {
            var tb = db.LostAndFound_Admin;
            var a = from t in tb where t.Room == "第四机房" select t;
        }

        protected void five(object sender, EventArgs e)
        {
            var tb = db.LostAndFound_Admin;
            var a = from t in tb where t.Room == "第五机房" select t;
        }

        protected void six(object sender, EventArgs e)
        {
            var tb = db.LostAndFound_Admin;
            var a = from t in tb where t.Room == "第六机房" select t;
        }

        protected void seven(object sender, EventArgs e)
        {
            var tb = db.LostAndFound_Admin;
            var a = from t in tb where t.Room == "第七机房" select t;
        }
        */
    }

}
