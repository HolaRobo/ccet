using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace LabManage
{
    public partial class LabOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString();
            
            DataSet ds = new DataSet();
            string sql = "select * from Newlab where Date = '"+ Convert.ToDateTime(date)+"'";
            ds = ADOHelp.QueryDataSet(sql);
            if (ds.Tables.Count!=0)
            {


                TextBox1.Text = ds.Tables[0].Rows[0][2].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0][3].ToString();
                TextBox15.Text = ds.Tables[0].Rows[0][4].ToString();
                TextBox16.Text = ds.Tables[0].Rows[0][5].ToString();
                TextBox29.Text = ds.Tables[0].Rows[0][6].ToString();

                TextBox3.Text = ds.Tables[0].Rows[1][2].ToString();
                TextBox4.Text = ds.Tables[0].Rows[1][3].ToString();
                TextBox17.Text = ds.Tables[0].Rows[1][4].ToString();
                TextBox18.Text = ds.Tables[0].Rows[1][5].ToString();
                TextBox30.Text = ds.Tables[0].Rows[1][6].ToString();

                TextBox5.Text = ds.Tables[0].Rows[2][2].ToString();
                TextBox6.Text = ds.Tables[0].Rows[2][3].ToString();
                TextBox19.Text = ds.Tables[0].Rows[2][4].ToString();
                TextBox20.Text = ds.Tables[0].Rows[2][5].ToString();
                TextBox31.Text = ds.Tables[0].Rows[2][6].ToString();

                TextBox7.Text = ds.Tables[0].Rows[3][2].ToString();
                TextBox8.Text = ds.Tables[0].Rows[3][3].ToString();
                TextBox21.Text = ds.Tables[0].Rows[3][4].ToString();
                TextBox22.Text = ds.Tables[0].Rows[3][5].ToString();
                TextBox32.Text = ds.Tables[0].Rows[3][6].ToString();

                TextBox9.Text = ds.Tables[0].Rows[4][2].ToString();
                TextBox10.Text = ds.Tables[0].Rows[4][3].ToString();
                TextBox23.Text = ds.Tables[0].Rows[4][4].ToString();
                TextBox24.Text = ds.Tables[0].Rows[4][5].ToString();
                TextBox33.Text = ds.Tables[0].Rows[4][6].ToString();

                TextBox11.Text = ds.Tables[0].Rows[5][2].ToString();
                TextBox12.Text = ds.Tables[0].Rows[5][3].ToString();
                TextBox25.Text = ds.Tables[0].Rows[5][4].ToString();
                TextBox26.Text = ds.Tables[0].Rows[5][5].ToString();
                TextBox34.Text = ds.Tables[0].Rows[5][6].ToString();

                TextBox13.Text = ds.Tables[0].Rows[6][2].ToString();
                TextBox14.Text = ds.Tables[0].Rows[6][3].ToString();
                TextBox27.Text = ds.Tables[0].Rows[6][4].ToString();
                TextBox28.Text = ds.Tables[0].Rows[6][5].ToString();
                TextBox35.Text = ds.Tables[0].Rows[6][6].ToString();
            }
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
           /* for(int m = 1; m <= 35; m ++)
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
            }*/
           
           string sql = "insert into Newlab values('" + Convert.ToDateTime(order_Time) + "','第一机房','" +s[1]+ "','" + s[2] + "','" + s[15] + " ','" + s[16] + "','"+s[29]+"')";
           int i = ADOHelp.ExecuteSql_ReturnRow(sql);
           sql = "insert into Newlab values('" + Convert.ToDateTime(order_Time) + "','第二机房','" + s[3] + "','" + s[4] + "','" + s[17] + " ','" + s[18] + "','" + s[30] + "')";
           i = ADOHelp.ExecuteSql_ReturnRow(sql);
            sql = "insert into Newlab values('" + Convert.ToDateTime(order_Time) + "','第三机房','" + s[5] + "','" + s[6] + "','" + s[19] + " ','" + s[20] + "','" + s[31] + "')";
            i = ADOHelp.ExecuteSql_ReturnRow(sql);
            sql = "insert into Newlab values('" + Convert.ToDateTime(order_Time) + "','第四机房','" + s[7] + "','" + s[8] + "','" + s[21] + " ','" + s[22] + "','" + s[32] + "')";
            i = ADOHelp.ExecuteSql_ReturnRow(sql);
            sql = "insert into Newlab values('" + Convert.ToDateTime(order_Time) + "','第五机房','" + s[9] + "','" + s[10] + "','" + s[23] + " ','" + s[24] + "','" + s[33] + "')";
            i = ADOHelp.ExecuteSql_ReturnRow(sql);
            sql = "insert into Newlab values('" + Convert.ToDateTime(order_Time) + "','第六机房','" + s[11] + "','" + s[12] + "','" + s[25] + " ','" + s[26] + "','" + s[34] + "')";
            i = ADOHelp.ExecuteSql_ReturnRow(sql);
            sql = "insert into Newlab values('" + Convert.ToDateTime(order_Time) + "','第七机房','" + s[13] + "','" + s[14] + "','" + s[27] + " ','" + s[28] + "','" + s[35] + "')";
            i = ADOHelp.ExecuteSql_ReturnRow(sql);
        }

      
    }
}