using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LabManage
{
    public partial class LabInfoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   
                //绑定实验室类型
                BindLabType();
                //绑定数据
                BindData(1,0);
            }
        }
        //绑定实验室类型
        private void BindLabType()
        {
            DataTable dt_type = ADOHelp.QueryDataTable("SELECT LabTypeID,LabTypeName FROM LabInfo_LabType");
            foreach (DataRow dr in dt_type.Rows)
            {
                DropDownList1.DataSource = dt_type;
                DropDownList1.DataTextField = "LabTypeName";
                DropDownList1.DataValueField = "LabTypeID";
                DropDownList1.DataBind();
            }
        }
        private void BindData(int LabTypeID, int MaxNO)
        {
            Repeater1.DataSource = ADOHelp.QueryDataTable("exec proc_SearchLabInfo "+LabTypeID+","+MaxNO+"");
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int MaxNO = 0;
            if (txtMaxNO.Value != "")
            {
                MaxNO = Convert.ToInt32(txtMaxNO.Value);
            }
            BindData(Convert.ToInt32(DropDownList1.SelectedValue), MaxNO);
        }
    }
}
