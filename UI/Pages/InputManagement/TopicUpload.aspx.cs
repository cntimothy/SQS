using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using SQS.DataStructure;
using SQS.Controller;

namespace SQS.UI.Pages.InputManagement
{
    public partial class TopicUpload : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindTopicInformationToGrid();
                bindYearsToDropDownList();
            }
        }
        #endregion

        #region Event
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

        protected void Button_Submit_Click(object sender, EventArgs e)
        {
            string exception = "";
            string fileName = Server.MapPath("../../upload/" + ViewState["filename"].ToString());
            if (InputManagementCtrl.InportTopicExcel(fileName, ref exception))
            {
                FileUpload_ExcelFile.Reset();
                Alert.ShowInTop("上传成功！", MessageBoxIcon.Information);
                bindTopicInformationToGrid();
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
            Response.AddHeader("content-disposition", "attachment;filename=" + Server.UrlEncode("课题信息模板.zip"));
            string path = Server.MapPath(@"..\..\downloadfiles\template\课题信息模板.zip");
            Response.TransmitFile(path);
        }

        /// <summary>
        /// 搜索类型改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SearchType_Changed(object sender, EventArgs e)
        {
            if (RadioButton_SearchByName.Checked == true)
            {
                TextBox_Name.Enabled = true;
                DropDownList_Depart.Enabled = false;
            }
            else
            {
                TextBox_Name.Enabled = false;
                DropDownList_Depart.Enabled = true;
            }
        }
        #endregion

        #region Private Method
        private void bindTopicInformationToGrid()
        {

        }

        /// <summary>
        /// 绑定从2013到当前年份到下拉列表
        /// </summary>
        private void bindYearsToDropDownList()
        {
            string exception = "";
            List<string> yearList = new List<string>();
            if (CommonCtrl.GetYearList(ref yearList, ref exception))
            {
                DropDownList_StartYear.DataSource = yearList;
                DropDownList_StartYear.DataBind();

                DropDownList_StopYear.DataSource = yearList;
                DropDownList_StopYear.DataBind();
            }
        }
        #endregion
    }
}