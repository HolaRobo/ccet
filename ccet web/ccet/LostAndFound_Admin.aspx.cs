using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.IO;

namespace LabManage
{
    public partial class LostAndFound_Admin : System.Web.UI.Page
    {
        /*
        string lostTime;
        string name;
        string type;
        string room;
        string description;
        string picName;
        */

        dbDataContext db = new dbDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(" <script   language=javascript> alert( \"警告!\"); </script> ");
        }
        /*
        public void ProcessRequest(HttpContext context)
        {
            HttpFileCollection files = context.Request.Files;              // From中获取文件对象
            if (files.Count > 0)
            {
                string path = "";                                                            //路径字符串
                Random rnd = new Random();
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFile file = files[i];                                        //得到文件对象
                    if (file.ContentLength > 0)
                    {
                        string fileName = file.FileName;
                        string extension = Path.GetExtension(fileName);
                        int num = rnd.Next(5000, 10000);                            //文件名称
                        path = "File/" + num.ToString() + extension;
                        file.SaveAs(System.Web.HttpContext.Current.Server.MapPath(path));        //保存文件。
                    }
                }
                context.Response.Write(path);            //返回文件存储后的路径，用于回显。
            }
        }
        */
       // /*
        #region 文件上传
        protected void picLoadClick(object sender, EventArgs e)
        {
            /*
           lostTime = Request.Form["dateInput"];
            name = Request.Form["lostName"];
            type = DropDownList2.SelectedItem.Text;
            room = roomSelect.SelectedItem.Text;
            description = this.des.Value;
            picName = FileUpload1.FileName;
            */
            if (FileUpload1.FileName =="")
            {
                this.loadLabel.Text = "上传文件不能为空";
                return;
            }

            bool fileIsValid = false;
            //如果确认了上传文件，则判断文件类型是否符合要求
            if (this.FileUpload1.HasFile)
            {
                //获取文件的后缀
                String fileExtension = System.IO.Path.GetExtension(this.FileUpload1.FileName).ToLower();
                String[] restrictExtension = { ".gif", ".jpg", ".bmp", ".png" };
                //判断文件类型是否符合要求
                for (int i = 0; i < restrictExtension.Length; i++)
                {
                    if (fileExtension == restrictExtension[i])
                        fileIsValid = true;
                }
                    //如果文件类型符合要求，调用SaveAs方法实现上传，并显示相关信息
                if(fileIsValid == true)
                {
                    //上传文件是否大于10M
                    if (FileUpload1.PostedFile.ContentLength > (10 * 1024 * 1024))
                    {
                        this.loadLabel.Text = "上传文件过大";
                        return;
                    }
                    try
                    {
                        //this.loadImage.ImageUrl = "File/" + FileUpload1.FileName;
                        //this.FileUpload1.SaveAs(Server.MapPath("File/") + FileUpload1.FileName);
                        
                        this.loadLabel.Text = "图片上传成功！";

                    }
                    catch
                    {
                        this.loadLabel.Text = "图片上传失败";
                    }
                    finally
                    {
                    
                    }
                }
                else
                {
                    this.loadLabel.Text = "只能够上传后缀为.gif .jpg .bmp .png的文件";
                }
                
            }
            
        }
        #endregion

        //*/
        protected void submitClick(object sender, EventArgs e)
        {


            if (FileUpload1.FileName == "")
            {
                this.loadLabel.Text = "上传文件不能为空";
                return;
            }

            bool fileIsValid = false;
            //如果确认了上传文件，则判断文件类型是否符合要求
            if (this.FileUpload1.HasFile)
            {
                //获取文件的后缀
                String fileExtension = System.IO.Path.GetExtension(this.FileUpload1.FileName).ToLower();
                String[] restrictExtension = { ".gif", ".jpg", ".bmp", ".png" };
                //判断文件类型是否符合要求
                for (int i = 0; i < restrictExtension.Length; i++)
                {
                    if (fileExtension == restrictExtension[i])
                        fileIsValid = true;
                }
                //如果文件类型符合要求，调用SaveAs方法实现上传，并显示相关信息
                if (fileIsValid == true)
                {
                    //上传文件是否大于10M
                    if (FileUpload1.PostedFile.ContentLength > (10 * 1024 * 1024))
                    {
                        this.loadLabel.Text = "上传文件过大";
                        return;
                    }
                    try
                    {
                        //this.loadImage.ImageUrl = "File/" + FileUpload1.FileName;
                        this.FileUpload1.SaveAs(Server.MapPath("File/") + FileUpload1.FileName);

                        this.loadLabel.Text = "图片上传成功！";

                    }
                    catch
                    {
                        this.loadLabel.Text = "图片上传失败";
                    }
                    finally
                    {

                    }
                }
                else
                {
                    this.loadLabel.Text = "只能够上传后缀为.gif .jpg .bmp .png的文件";
                }

            }

            string lostTime = Request.Form["dateInput"];
            string name = Request.Form["lostName"];
            string type = DropDownList2.SelectedItem.Text;
            string room = roomSelect.SelectedItem.Text;
            string description = this.des.Value;
            string picName = FileUpload1.FileName;       
            
            if (lostTime == "" || name == "")
            {

            }
            else
            {

                var tab = db.LostAndFound_Admin;

                string sql = "insert into LostAndFound_Admin values('" + name + "','" + type + "','" + room + "','" + lostTime + "','" + System.DateTime.Now + "','" + description + "','" + picName + "');";
                int i = ADOHelp.ExecuteSql_ReturnRow(sql);

                Response.Redirect("LostAndFound_List.aspx");
            }
        }
       
        /*
        protected void change(object sender, EventArgs e)
        {
            Response.Redirect("LostAndFound_Admin2.aspx");
        } 
        */
    }
}