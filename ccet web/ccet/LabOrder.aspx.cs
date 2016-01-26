using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManage
{
    public partial class LabOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string lab = "";
            string stage;
            string time;
            string order_Time = Request.Form["orderDate"];
            string[] s = new string[36];
            s[1] = TextBox1.Text;
            s[2] = TextBox2.Text;
            s[3] = TextBox3.Text;
            s[4] = TextBox4.Text;
            s[5] = TextBox5.Text;
            s[6] = TextBox6.Text;
            s[7] = TextBox7.Text;
            s[8] = TextBox8.Text;
            s[9] = TextBox9.Text;
            s[10] = TextBox10.Text;
            s[11] = TextBox11.Text;
            s[12] = TextBox12.Text;
            s[13] = TextBox13.Text;
            s[14] = TextBox14.Text;
            s[15] = TextBox15.Text;
            s[16] = TextBox16.Text;
            s[17] = TextBox17.Text;
            s[18] = TextBox18.Text;
            s[19] = TextBox19.Text;
            s[20] = TextBox20.Text;
            s[21] = TextBox21.Text;
            s[22] = TextBox22.Text;
            s[23] = TextBox23.Text;
            s[24] = TextBox24.Text;
            s[25] = TextBox25.Text;
            s[26] = TextBox26.Text;
            s[27] = TextBox27.Text;
            s[28] = TextBox28.Text;
            s[29] = TextBox29.Text;
            s[30] = TextBox30.Text;
            s[31] = TextBox31.Text;
            s[32] = TextBox32.Text;
            s[33] = TextBox33.Text;
            s[34] = TextBox34.Text;
            s[35] = TextBox35.Text;
            string date = DateTime.Now.ToString();
            for(int m = 1; m <= 35; m ++)
            {
                
                if (m<15)
                {
                    stage = "上午";
                    if(m % 2 == 0)
                    {
                        time = "三四节";
                        int n = m / 2;
                        switch (n)
                        {
                            case 1:
                                lab = "第一机房";
                                break;
                            case 2:
                                lab = "第二机房";
                                break;
                            case 3:
                                lab = "第三机房";
                                break;
                            case 4:
                                lab = "第四机房";
                                break;
                            case 5:
                                lab = "第五机房";
                                break;
                            case 6:
                                lab = "第六机房";
                                break;
                            case 7:
                                lab = "第七机房";
                                break;

                        }
                    }
                    else
                    {
                        time = "一二节";
                        int n = m / 2 + 1;
                        switch (n)
                        {
                            case 1:
                                lab = "第一机房";
                                break;
                            case 2:
                                lab = "第二机房";
                                break;
                            case 3:
                                lab = "第三机房";
                                break;
                            case 4:
                                lab = "第四机房";
                                break;
                            case 5:
                                lab = "第五机房";
                                break;
                            case 6:
                                lab = "第六机房";
                                break;
                            case 7:
                                lab = "第七机房";
                                break;

                        }
                    }
                }
                else if(m > 14 && m < 29)
                {
                    stage = "下午";
                    if (m % 2 == 0)
                    {
                        time = "三四节";
                        int n = m / 2 - 7;
                        switch (n)
                        {
                            case 1:
                                lab = "第一机房";
                                break;
                            case 2:
                                lab = "第二机房";
                                break;
                            case 3:
                                lab = "第三机房";
                                break;
                            case 4:
                                lab = "第四机房";
                                break;
                            case 5:
                                lab = "第五机房";
                                break;
                            case 6:
                                lab = "第六机房";
                                break;
                            case 7:
                                lab = "第七机房";
                                break;

                        }
                    }
                    else
                    {
                        time = "一二节";
                        int n = m / 2 - 6;
                        switch (n)
                        {
                            case 1:
                                lab = "第一机房";
                                break;
                            case 2:
                                lab = "第二机房";
                                break;
                            case 3:
                                lab = "第三机房";
                                break;
                            case 4:
                                lab = "第四机房";
                                break;
                            case 5:
                                lab = "第五机房";
                                break;
                            case 6:
                                lab = "第六机房";
                                break;
                            case 7:
                                lab = "第七机房";
                                break;

                        }
                    }
                }
                else
                {
                    stage = "晚上";
                    time = "晚上";
                    int n = m - 28;
                    switch (n)
                    {
                        case 1:
                            lab = "第一机房";
                            break;
                        case 2:
                            lab = "第二机房";
                            break;
                        case 3:
                            lab = "第三机房";
                            break;
                        case 4:
                            lab = "第四机房";
                            break;
                        case 5:
                            lab = "第五机房";
                            break;
                        case 6:
                            lab = "第六机房";
                            break;
                        case 7:
                            lab = "第七机房";
                            break;

                    }
                }

                if (s[m] != "")
                {
                    string sql = "insert into Newlab values('" + lab + "','" + stage + "','" + time + "','" + s[m] + "','" + Convert.ToDateTime
                        (date) +" ','"+ Convert.ToDateTime(order_Time) +"')";
                    int i = ADOHelp.ExecuteSql_ReturnRow(sql);
                }
            }
            
        }

    }
}