using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQS.Controller;
using SQS.DataStructure;
using FineUI;
using System.Data;
using System.Web.Script.Serialization;
using System.Text;

namespace SQS.UI.Pages.InputManagement
{
    public partial class BookUpload : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindDepartToDropDownList();
                bindBookInformationToGrid();
            }
        }
        #endregion

        #region Event
        /// <summary>
        /// 选择上传文件事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void FileUpload_ExcelFile_FileSelected(object sender, EventArgs e)
        {
            if (FileUpload_ExcelFile.HasFile)
            {
                string fileName = FileUpload_ExcelFile.ShortFileName;

                if (!fileName.EndsWith(".xls"))
                {
                    Button_Submit.Enabled = false;
                    Label_FileName.Text = "";
                    FileUpload_ExcelFile.Reset();
                    Alert.Show("无效的文件！", MessageBoxIcon.Error);
                    return;
                }

                Label_FileName.Text = fileName;
                fileName = DateTime.Now.Ticks.ToString() + "_" + fileName;
                ViewState["filename"] = fileName;

                FileUpload_ExcelFile.SaveAs(Server.MapPath("~/upload/" + fileName));


                Button_Submit.Enabled = true;
                // 清空文件上传组件
                FileUpload_ExcelFile.Reset();
            }
        }

        /// <summary>
        /// 开始上传事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Submit_Click(object sender, EventArgs e)
        {
            string exception = "";
            string fileName = Server.MapPath("../../upload/" + ViewState["filename"].ToString());
            int createCount = 0, updateCount = 0;   //新增数量和更新数量
            if (InputManagementCtrl.InportBookExcel(fileName, ref createCount, ref updateCount, ref exception))
            {
                FileUpload_ExcelFile.Reset();
                Alert.ShowInTop("上传成功！", MessageBoxIcon.Information);
                bindBookInformationToGrid();
            }
            else
            {
                FileUpload_ExcelFile.Reset();
                Alert.ShowInTop("上传失败！\n失败原因：" + exception, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 下载模板事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_DownloadTemplate_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.ContentType = "application/x-zip-compressed";
            Response.AddHeader("content-disposition", "attachment;filename=" + Server.UrlEncode("著作信息模板.zip"));
            string path = Server.MapPath(@"..\..\downloadfiles\template\著作信息模板.zip");
            Response.TransmitFile(path);
        }

        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Delete_Click(object sender, EventArgs e)
        {
            syncSelectedRowIndexArrayToHiddenField();   //同步所选到hidden field
            string exception = "";
            string s = hfSelectedIDS.Text.Trim().TrimStart('[').TrimEnd(']');
            if (s == "")
            {
                Alert.ShowInTop("请至少选择一项！", MessageBoxIcon.Information);
                return;
            }
            List<string> IDs = new List<string>();
            string[] tempIDs = s.Split(',');
            foreach (string item in tempIDs)
            {
                IDs.Add(item.Trim('"'));
            }
            if (InputManagementCtrl.DeleteBooksByIds(IDs, ref exception))
            {
                Alert.ShowInTop("删除成功", MessageBoxIcon.Information);
                hfSelectedIDS.Text = "";
                bindBookInformationToGrid();
            }
            else
            {
                Alert.ShowInTop("删除失败\n原因：" + exception, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 搜索事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Search_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (!checkAvailable(ref errorMessage))
            {
                Alert.ShowInTop(errorMessage, MessageBoxIcon.Warning);
                return;
            }

            //构造搜索条件
            string departId = DropDownList_Depart.SelectedValue == "0" ? "" : DropDownList_Depart.SelectedValue;
            string officeId = DropDownList_Office.SelectedValue == "0" ? "" : DropDownList_Office.SelectedValue;
            SearchCondition searchCondition = new SearchCondition(TextBox_Name.Text.Trim(), TextBox_BookName.Text.Trim(),
                departId, officeId,
                DatePicker_PublishDateStart.Text.Trim(), DatePicker_PublishDateStop.Text.Trim(), 
                DatePicker_CreateDateStart.Text.Trim(), DatePicker_CreateDateStop.Text.Trim(), 
                DatePicker_UpdateDateStart.Text.Trim(), DatePicker_UpdateDateStop.Text.Trim());
            string exception = "";
            DataTable table = new DataTable();
            if (InputManagementCtrl.GetBookInformationByCondition(ref table, searchCondition, ref exception))
            {
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
            else
            {
                Alert.ShowInTop(exception, MessageBoxIcon.Error);
                table.Clear();
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
        }

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

        /// <summary>
        /// 换页事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            syncSelectedRowIndexArrayToHiddenField();

            Grid1.PageIndex = e.NewPageIndex;

            updateSelectedRowIndexArray();

        }

        /// <summary>
        /// 导出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Export_Click(object sender, EventArgs e)
        {
            string exception = "";
            DataTable table = getDataTableFromGrid();
            string fileName = "";
            if (ExportManagementCtrl.ExportStaticalCountForDepart(ref fileName, table, ref exception))
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
        /// 绑定著作信息到grid
        /// </summary>
        private void bindBookInformationToGrid()
        {
            string exception = "";
            DataTable table = new DataTable();
            if (InputManagementCtrl.GetAllBookInformation(ref table, ref exception))
            {
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
            else
            {
                Alert.ShowInTop(exception, MessageBoxIcon.Error);
                table.Clear();
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
        }

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
        /// 从HiddenField同步已选择的项，用于保持跨页选中
        /// </summary>
        /// <returns></returns>
        private List<string> getSelectedRowIndexArrayFromHiddenField()
        {
            List<string> ids = new List<string>();
            string currentids = hfSelectedIDS.Text.Trim();
            if (!String.IsNullOrEmpty(currentids))
            {
                try
                {
                    ids = (new JavaScriptSerializer()).Deserialize<List<string>>(currentids);
                }
                catch (Exception)
                {
                    Alert.ShowInTop("内部错误！\n错误原因：Json反序列化错误", MessageBoxIcon.Error);
                    return null;
                }
            }

            return ids;
        }

        /// <summary>
        /// 向HiddenField同步已选择的项，用于保持跨页选中
        /// </summary>
        private void syncSelectedRowIndexArrayToHiddenField()
        {
            List<string> ids = getSelectedRowIndexArrayFromHiddenField();
            List<int> selectedRows = new List<int>();
            if (Grid1.SelectedRowIndexArray != null && Grid1.SelectedRowIndexArray.Length > 0)
            {
                selectedRows = new List<int>(Grid1.SelectedRowIndexArray);
            }
            int startPageIndex = Grid1.PageIndex * Grid1.PageSize;
            for (int i = startPageIndex, count = Math.Min(startPageIndex + Grid1.PageSize, Grid1.RecordCount); i < count; i++)
            {
                string id = Grid1.DataKeys[i][0].ToString();
                if (selectedRows.Contains(i - startPageIndex))
                {
                    if (!ids.Contains(id))
                    {
                        ids.Add(id);
                    }
                }
                else
                {
                    if (ids.Contains(id))
                    {
                        ids.Remove(id);
                    }
                }

            }

            hfSelectedIDS.Text = (new JavaScriptSerializer()).Serialize(ids);
        }

        /// <summary>
        /// 更新已选择项，用于保持跨页选中
        /// </summary>
        private void updateSelectedRowIndexArray()
        {
            List<string> ids = getSelectedRowIndexArrayFromHiddenField();

            List<int> nextSelectedRowIndexArray = new List<int>();
            int nextStartPageIndex = Grid1.PageIndex * Grid1.PageSize;
            for (int i = nextStartPageIndex, count = Math.Min(nextStartPageIndex + Grid1.PageSize, Grid1.RecordCount); i < count; i++)
            {
                string id = Grid1.DataKeys[i][0].ToString();
                if (ids.Contains(id))
                {
                    nextSelectedRowIndexArray.Add(i - nextStartPageIndex);
                }
            }
            Grid1.SelectedRowIndexArray = nextSelectedRowIndexArray.ToArray();
        }

        /// <summary>
        /// 将Grid中的数据转化为table
        /// </summary>
        /// <returns></returns>
        private DataTable getDataTableFromGrid()
        {
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

        /// <summary>
        /// 检测搜索条件是否合法,合法返回true，否则返回false
        /// </summary>
        /// <param name="errorEessage">错误信息</param>
        /// <returns>合法返回true，否则返回false</returns>
        private bool checkAvailable(ref string errorEessage)
        {
            //检测是否为空
            if (TextBox_Name.Text.Trim() == "" && TextBox_BookName.Text.Trim() == ""
                && DropDownList_Depart.SelectedValue == "0"
                && !DatePicker_PublishDateStart.SelectedDate.HasValue
                && !DatePicker_PublishDateStop.SelectedDate.HasValue
                && !DatePicker_CreateDateStart.SelectedDate.HasValue
                && !DatePicker_CreateDateStop.SelectedDate.HasValue
                && !DatePicker_UpdateDateStart.SelectedDate.HasValue
                && !DatePicker_UpdateDateStop.SelectedDate.HasValue)
            {
                errorEessage = "请至少选择一项！";
                return false;
            }

            if (DatePicker_PublishDateStart.Text == "" && DatePicker_PublishDateStop.Text != "")
            {
                errorEessage = "请选择出版时间（始）！";
                return false;
            }

            if (DatePicker_PublishDateStart.Text != "" && DatePicker_PublishDateStop.Text == "")
            {
                errorEessage = "请选择出版时间（止）！";
                return false;
            }

            if (DatePicker_CreateDateStart.Text == "" && DatePicker_CreateDateStop.Text != "")
            {
                errorEessage = "请选择上传时间（始）！";
                return false;
            }

            if (DatePicker_CreateDateStart.Text != "" && DatePicker_CreateDateStop.Text == "")
            {
                errorEessage = "请选择上传出版时间（止）";
                return false;
            }

            if (DatePicker_UpdateDateStart.Text == "" && DatePicker_UpdateDateStop.Text != "")
            {
                errorEessage = "请选择更新时间（始）！";
                return false;
            }

            if (DatePicker_UpdateDateStart.Text != "" && DatePicker_UpdateDateStop.Text == "")
            {
                errorEessage = "请选择更新时间（止）！";
                return false;
            }

            //检测结束日期是否大于开始日期
            if (DatePicker_PublishDateStart.SelectedDate > DatePicker_PublishDateStop.SelectedDate
                || DatePicker_CreateDateStart.SelectedDate > DatePicker_CreateDateStop.SelectedDate
                || DatePicker_UpdateDateStart.SelectedDate > DatePicker_UpdateDateStop.SelectedDate)
            {
                errorEessage = "结束日期需大于开始日期，请重新选择！";
                return false;
            }
            return true;
        }
        #endregion
    }
}