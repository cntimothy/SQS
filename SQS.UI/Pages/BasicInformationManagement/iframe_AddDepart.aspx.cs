using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using SQS.Controller;

namespace SQS.UI.Pages.BasicInformationManagement
{
    public partial class iframe_AddDepart : PageBase
    {
        #region PageInit
        protected void Page_Load(object sender, EventArgs e)
        {
            Button_Cancel.OnClientClick = ActiveWindow.GetHideReference();
        }
        #endregion

        #region Event
        /// <summary>
        /// 新增部系事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_AddNew_Click(object sender, EventArgs e)
        {
            if (TextBox_NewDepart.Text == "")
            {
                Alert.ShowInTop("请输入新的部系名称!", MessageBoxIcon.Warning);
                return;
            }
            string exception = "";
            string newDepartName = TextBox_NewDepart.Text;
            if (BasicInformationManagementCtrl.AddNewDepart(newDepartName, ref exception))
            {
                Alert.ShowInTop("新增成功！", MessageBoxIcon.Information);
                PageContext.RegisterStartupScript(ActiveWindow.GetHideReference());
            }
            else
            {
                Alert.ShowInTop("新增失败！\n原因：" + exception, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        #region Private Method
        #endregion
    }
}