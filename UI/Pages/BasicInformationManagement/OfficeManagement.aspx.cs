using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQS.DataStructure;
using SQS.Controller;
using FineUI;
using System.Data;

namespace SQS.UI.Pages.BasicInformationManagement
{
    public partial class OfficeManegement : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setButtonEvent();   //设置按钮事件
                bindDepartOfficeToGrid();
            }
        }
        #endregion

        #region Event
        protected void Button_Refresh_Click(object sender, EventArgs e)
        {
            bindDepartOfficeToGrid();
        }
        #endregion

        #region Private Method
        /// <summary>
        /// 绑定部系处室信息到Grid
        /// </summary>
        private void bindDepartOfficeToGrid()
        {
            string exception = "";
            List<Depart> departList = new List<Depart>();
            if (BasicInformationManagementCtrl.GetAllDepartOffice(ref departList, ref exception))
            {
                DataTable table = getDataTable(departList);
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
            else
            {
                Alert.ShowInTop(exception);
                DataTable table = new DataTable();
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
        }

        /// <summary>
        /// 从部系列表中构造DataTable
        /// </summary>
        /// <param name="departList"></param>
        private DataTable getDataTable(List<Depart> departList)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Depart");
            table.Columns.Add("Office");
            foreach(Depart depart in departList)
            {
                DataRow row1 = table.NewRow();
                row1["Depart"] = depart.Name;
                row1["Office"] = depart.Offices[0].Name;
                table.Rows.Add(row1);
                for (int i = 1; i < depart.Offices.Count; i++)
                {
                    DataRow row2 = table.NewRow();
                    row2["Depart"] = "";
                    row2["Office"] = depart.Offices[i].Name;
                    table.Rows.Add(row2);
                }
            }

            return table;
        }

        /// <summary>
        /// 设置按钮事件
        /// </summary>
        private void setButtonEvent()
        {
            Button_AddDepart.OnClientClick = Window1.GetShowReference("iframe_AddDepart.aspx", "操作");
            Button_DeleteDepart.OnClientClick = Window1.GetShowReference("iframe_DeleteDepart.aspx", "操作");
            Button_AddOffice.OnClientClick = Window1.GetShowReference("iframe_AddOffice.aspx", "操作");
            Button_DeleteOffice.OnClientClick = Window1.GetShowReference("iframe_DeleteOffice.aspx", "操作");
        }
        #endregion
    }
}