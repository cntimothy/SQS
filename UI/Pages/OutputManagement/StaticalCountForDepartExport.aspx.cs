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

namespace SQS.UI.Pages.OutputManagement
{
    public partial class StaticalCountForDepartExport : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindYearToDropDownList();
            }
        }
        #endregion

        #region Event
        protected void Button_GetResult_Click(object sender, EventArgs e)
        {
            if (DropDownList_StartYear.SelectedValue == "0")
            {
                Alert.ShowInTop("请选择开始年份！", MessageBoxIcon.Warning);
                return;
            }
            if (DropDownList_StopYear.SelectedValue == "0")
            {
                Alert.ShowInTop("请选择结束年份！", MessageBoxIcon.Warning);
                return;
            }
            string startTime = DropDownList_StartYear.SelectedValue + "-" + DropDownList_StartMonth.SelectedValue;
            string stopTime = DropDownList_StopYear.SelectedValue + "-" + DropDownList_StopMonth.SelectedValue;

            DateTime d1 = Convert.ToDateTime(startTime);
            DateTime d2 = Convert.ToDateTime(stopTime);
            if (d1 > d2)
            {
                Alert.ShowInTop("结束时间必须大于开始时间！", MessageBoxIcon.Warning);
                return;
            }

            DataTable table = new DataTable();
            string exception = "";
            if (OutputManagementCtrl.GetCountResultDepart(ref table, startTime, stopTime, ref exception))
            {
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
            else
            {
                Alert.ShowInTop(exception);
                table.Clear();
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
        }
        #endregion

        #region Private Method
        /// <summary>
        /// 绑定年份到下拉列表
        /// </summary>
        private void bindYearToDropDownList()
        {
            string exception = "";
            List<string> yearList = new List<string>();
            if (CommonCtrl.GetYearList(ref yearList, ref exception))
            {
                foreach (string year in yearList)
                {
                    DropDownList_StartYear.Items.Add(year, year);
                    DropDownList_StopYear.Items.Add(year, year);
                }
            }
        }

        /// <summary>
        /// 将Grid中的数据转化为table
        /// </summary>
        /// <returns></returns>
        private DataTable getDataTableFromGrid()
        {
            string exception = "";
            List<string> publishGradeNameListForPaper = new List<string>();
            List<string> publishGradeNameListForBook = new List<string>();
            List<string> topicGradeNameList = new List<string>();
            DataTable table = new DataTable();
            foreach (GridColumn column in Grid1.Columns)
            {
                if (column.HeaderText == "操作")
                {
                    continue;
                }
                table.Columns.Add(column.HeaderText);
            }
            foreach (GridRow gridRow in Grid1.Rows)
            {
                DataRow dataRow = table.NewRow();
                for (int i = 0; i < gridRow.Values.Length - 1; i++)    //去掉最后一列
                {
                    dataRow[i] = gridRow.Values[i];
                }
                table.Rows.Add(dataRow);
            }
            return table;
        }
        #endregion
    }
}