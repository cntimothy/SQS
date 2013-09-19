using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using SQS.Controller;
using SQS.DataStructure;
using System.Data;

namespace SQS.UI.Pages.InputManagement
{
    public partial class StaffUpload : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindStaffInformationToGrid();
            }
        }
        #endregion

        #region Event
        /// <summary>
        /// 上传控件事件
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
        ///开始上传事件 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Submit_Click(object sender, EventArgs e)
        {
            string exception = "";
            string fileName = Server.MapPath("../../upload/" + ViewState["filename"].ToString());
            if (InputManagementCtrl.InportStaffExcel(fileName, ref exception))
            {
                FileUpload_ExcelFile.Reset();
                Alert.ShowInTop("上传成功！", MessageBoxIcon.Information);
                bindStaffInformationToGrid();
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
            Response.AddHeader("content-disposition", "attachment;filename=" + Server.UrlEncode("人员信息模板.zip"));
            string path = Server.MapPath(@"..\..\downloadfiles\template\人员信息模板.zip");
            Response.TransmitFile(path);
        }

        protected void Button_Export_Click(object sender, EventArgs e)
        {
            string exception = "";
            List<DepartStaffInformation> departList = new List<DepartStaffInformation>();
            if (InputManagementCtrl.GetAllStaffInformation(ref departList, ref exception))
            {
                string fileName = "";
                if (ExportManagementCtrl.ExportStaffInformation(ref fileName, departList, ref exception))
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
            else
            {
                Alert.ShowInTop("导出失败！\n原因：" + exception, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Private Method
        /// <summary>
        /// 绑定人员信息到Grid
        /// </summary>
        private void bindStaffInformationToGrid()
        {
            string exception = "";
            List<DepartStaffInformation> departList = new List<DepartStaffInformation>();
            if (InputManagementCtrl.GetAllStaffInformation(ref departList, ref exception))
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
        /// 根据departList的内容填充DataTable
        /// </summary>
        /// <param name="departList"></param>
        /// <returns></returns>
        private DataTable getDataTable(List<DepartStaffInformation> departList)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Depart");
            table.Columns.Add("Office");
            table.Columns.Add("DepartStaffCount");
            table.Columns.Add("OfficeStaffCount");
            foreach (DepartStaffInformation depart in departList)
            {
                DataRow row1 = table.NewRow();
                row1["Depart"] = depart.Name;
                row1["Office"] = depart.Offices[0].Name;
                row1["OfficeStaffCount"] = depart.Offices[0].StaffCount;
                row1["DepartStaffCount"] = depart.StaffCount;
                table.Rows.Add(row1);

                for (int i = 1; i < depart.Offices.Count; i++)
                {
                    DataRow row2 = table.NewRow();
                    row2["Depart"] = "";
                    row2["Office"] = depart.Offices[i].Name;
                    row2["OfficeStaffCount"] = depart.Offices[i].StaffCount;
                    row2["DepartStaffCount"] = "";
                    table.Rows.Add(row2);
                }
            }
            
            return table;
        }
        #endregion
    }
}