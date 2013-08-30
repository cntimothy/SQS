using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQS.Controller;
using SQS.DataStructure;
using FineUI;

namespace SQS.UI.Pages.InputManagement
{
    public partial class BookUpload : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {

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
            if (InputManagementCtrl.InportBookExcel(fileName, ref exception))
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
        #endregion

        #region Private Method
        private void bindBookInformationToGrid()
        { 
        
        }
        #endregion
    }
}