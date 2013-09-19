using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using SQS.Controller;

namespace SQS.UI.Pages.PublicityManagement
{
    public partial class StartOrStop : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadPublicityStatus();
            }
        }
        #endregion

        #region Event
        /// <summary>
        /// 开始公示事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Start_Click(object sender, EventArgs e)
        {
            string exception = "";
            if (PublicityManagementCtrl.StartPublicity(ref exception))
            {
                Alert.ShowInTop("设置成功！", MessageBoxIcon.Information);
            }
            else
            {
                Alert.ShowInTop("设置失败！原因：" + exception, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 结束公示事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Stop_Click(object sender, EventArgs e)
        {
            string exception = "";
            if (PublicityManagementCtrl.StopPublicity(ref exception))
            {
                Alert.ShowInTop("设置成功！", MessageBoxIcon.Information);
            }
            else
            {
                Alert.ShowInTop("设置失败！原因：" + exception, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Private Method
        private void loadPublicityStatus()
        {
            string exception = "";
            if (PublicityManagementCtrl.IsPublicityStarted(ref exception))
            {
                Label_Status.Text = "公示已开始！";
            }
            else
            {
                Label_Status.Text = "公示未开始！";
            }
        }
        #endregion
    }
}