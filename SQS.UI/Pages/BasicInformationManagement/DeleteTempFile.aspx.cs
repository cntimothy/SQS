using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQS.DataStructure;
using SQS.Controller;
using FineUI;

namespace SQS.UI.Pages.BasicInformationManagement
{
    public partial class DeleteTempFile : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Event
        protected void Button_Delete_Click(object sender, EventArgs e)
        {
            string exception = "";
            if (BasicInformationManagementCtrl.ClearTempFiles(ref exception))
            {
                Alert.ShowInTop("删除成功！", MessageBoxIcon.Information);
                return;
            }
            else
            {
                Alert.ShowInTop("删除失败！\n原因：" + exception, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        #region Private Method

        #endregion
    }
}