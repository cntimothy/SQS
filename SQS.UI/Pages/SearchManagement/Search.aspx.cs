using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQS.Controller;
using FineUI;
using SQS.DataStructure;
using System.Data;

namespace SQS.UI.Pages.SearchManagement
{
    public partial class Search : System.Web.UI.Page
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindDepartToDropDownList();
            }
        }
        #endregion

        #region Event
        /// <summary>
        /// 部系下拉列表事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DropDownList_Depart_SelectedChanged(object sender, EventArgs e)
        {
            if (DropDownList_Depart.SelectedValue == "0")
            {
                DropDownList_Office.SelectedValue = "0";
                DropDownList_Office.Enabled = false;
            }
            else
            {
                DropDownList_Office.Enabled = true;
                bindOfficeToDropDownList();
            }
        }

        protected void Button_Search_Click(object sender, EventArgs e)
        {
            if (DatePicker_PublishDateStart.Text == "" && DatePicker_PublishDateStop.Text == "" 
                && TextBox_Name.Text == "" && TextBox_WorkName.Text == "" 
                && DropDownList_Depart.SelectedValue == "0" && DropDownList_Depart.SelectedValue == "0")
            {
                Alert.ShowInTop("请至少选择一项！！", MessageBoxIcon.Error);
                return;
            }
            if (DatePicker_PublishDateStart.Text != "" && DatePicker_PublishDateStop.Text == "")
            {
                Alert.ShowInTop("请选择结束时间！", MessageBoxIcon.Error);
                return;
            }
            if (DatePicker_PublishDateStart.Text == "" && DatePicker_PublishDateStop.Text != "")
            {
                Alert.ShowInTop("请选择开始时间！", MessageBoxIcon.Error);
                return;
            }
            string name = TextBox_Name.Text;
            string workName = TextBox_WorkName.Text;
            string departId = DropDownList_Depart.SelectedValue == "0" ? "" : DropDownList_Depart.SelectedValue;
            string officeId = DropDownList_Office.SelectedValue == "0" ? "" : DropDownList_Office.SelectedValue;
            string publishDateStart = DatePicker_PublishDateStart.Text;
            string publishDataStop = DatePicker_PublishDateStop.Text;
            SearchCondition searchCondition = new SearchCondition(name, workName, departId, officeId, publishDateStart, publishDataStop, 
                                                    "", "", "", "");
            string exception = "";
            DataTable tableForPaper = new DataTable();
            DataTable tableForBook = new DataTable();
            DataTable tableForTopic = new DataTable();
            if(SearchManagementCtrl.SearchPaper(ref tableForPaper, searchCondition, ref exception))
            {
                Grid_Paper.DataSource = tableForPaper;
                Grid_Paper.DataBind();
            }
            exception = "";

            if (SearchManagementCtrl.SearchBook(ref tableForBook, searchCondition, ref exception))
            {
                Grid_Book.DataSource = tableForBook;
                Grid_Book.DataBind();
            }
            exception = "";

            if (SearchManagementCtrl.SearchTopic(ref tableForTopic, searchCondition, ref exception))
            {
                Grid_Topic.DataSource = tableForTopic;
                Grid_Topic.DataBind();
            }
        }

        /// <summary>
        /// 导出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Export_Click(object sender, EventArgs e)
        {
            string exception = "";
            DataTable tableForPaper = getDataTableFromGrid(Grid_Paper);
            DataTable tableForBook = getDataTableFromGrid(Grid_Book);
            DataTable tableForTopic = getDataTableFromGrid(Grid_Topic);
            string fileName = "";
            if (ExportManagementCtrl.ExportSearchResult(ref fileName, tableForPaper, tableForBook, tableForTopic, ref exception))
            {
                Response.ClearContent();
                Response.ContentType = "application/excel";
                Response.AddHeader("content-disposition", "attachment;filename=" + Server.UrlEncode(fileName));
                string path = Server.MapPath("..\\..\\downloadfiles\\" + fileName);
                Response.TransmitFile(path);
            }
            else
            {
                Alert.ShowInTop("导出失败！\n原因：" + exception, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Private Method
        /// <summary>
        /// 绑定部系到下拉列表
        /// </summary>
        private void bindDepartToDropDownList()
        {
            DropDownList_Depart.Items.Clear();
            DropDownList_Depart.Items.Add("所有部系", "0");
            string exception = "";
            Dictionary<string, string> idNameDic = new Dictionary<string, string>();
            if (CommonCtrl.GetDepartIdNameDic(ref idNameDic, ref exception))
            {
                foreach (string id in idNameDic.Keys)
                {
                    DropDownList_Depart.Items.Add(idNameDic[id], id);
                }
            }
        }

        /// <summary>
        /// 绑定处室到下拉列表
        /// </summary>
        private void bindOfficeToDropDownList()
        {
            DropDownList_Office.Items.Clear();
            DropDownList_Office.Items.Add("所有处室", "0");
            string departId = DropDownList_Depart.SelectedValue;
            if (departId != "0")
            {
                Dictionary<string, string> idNameDic = new Dictionary<string, string>();
                string exception = "";
                if (CommonCtrl.GetOfficeIdNameDicByDepartId(ref idNameDic, departId, ref exception))
                {
                    foreach (string id in idNameDic.Keys)
                    {
                        DropDownList_Office.Items.Add(idNameDic[id], id);
                    }
                }
            }
        }

        /// <summary>
        /// 将Grid中的数据转化为table
        /// </summary>
        /// <returns></returns>
        private DataTable getDataTableFromGrid(Grid grid)
        {
            DataTable table = new DataTable();
            foreach (GridColumn column in grid.Columns)
            {
                table.Columns.Add(column.HeaderText);
            }
            foreach (GridRow gridRow in grid.Rows)
            {
                DataRow dataRow = table.NewRow();
                for (int i = 0; i < gridRow.Values.Length; i++)    //去掉最后一列
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