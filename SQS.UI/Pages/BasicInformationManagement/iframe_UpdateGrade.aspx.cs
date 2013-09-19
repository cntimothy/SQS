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
    public partial class iframe_UpdateGrade : PageBase
    {
        #region PageInit
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //设置取消按钮事件
                Button_Cancel.OnClientClick = ActiveWindow.GetHideRefreshReference();

                ViewState["id"] = Request.QueryString["id"];
                ViewState["source"] = Request.QueryString["source"];
                //Alert.Show(ViewState["source"].ToString());
            }
        }
        #endregion

        #region Event
        protected void Button_Update_Click(object sender, EventArgs e)
        {
            if (TextBox_NewName.Text.Trim() == "")
            {
                Alert.ShowInTop("请填写新名称！", MessageBoxIcon.Warning);
                return;
            }
            string id = ViewState["id"].ToString();
            string exception = "";
            string newName = TextBox_NewName.Text.Trim();
            string source = ViewState["source"].ToString();
            if (source == "paper")  //修改论文发表级别
            {
                if (BasicInformationManagementCtrl.UpdatePublishGradeNameForPaper(id, newName, ref exception))
                {
                    Alert.ShowInTop("修改成功！", MessageBoxIcon.Information);
                    PageContext.RegisterStartupScript(ActiveWindow.GetHideReference());
                }
                else
                {
                    Alert.ShowInTop("修改失败！\n原因：" + exception, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (source == "book")  //修改著作发行级别
            {
                if (BasicInformationManagementCtrl.UpdatePublishGradeNameForBook(id, newName, ref exception))
                {
                    Alert.ShowInTop("修改成功！", MessageBoxIcon.Information);
                    PageContext.RegisterStartupScript(ActiveWindow.GetHideReference());
                }
                else
                {
                    Alert.ShowInTop("修改失败！\n原因：" + exception, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (source == "topic") //修改课题级别
            {
                if (BasicInformationManagementCtrl.UpdateTopicGradeNameForTopic(id, newName, ref exception))
                {
                    Alert.ShowInTop("修改成功！", MessageBoxIcon.Information);
                    PageContext.RegisterStartupScript(ActiveWindow.GetHideReference());
                }
                else
                {
                    Alert.ShowInTop("修改失败！\n原因：" + exception, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (source == "rewardgrade")   //修改获奖级别
            {
                if (BasicInformationManagementCtrl.UpdateRewardGradeName(id, newName, ref exception))
                {
                    Alert.ShowInTop("修改成功！", MessageBoxIcon.Information);
                    PageContext.RegisterStartupScript(ActiveWindow.GetHideReference());
                }
                else
                {
                    Alert.ShowInTop("修改失败！\n原因：" + exception, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (source == "rewardclass")   //修改获奖等级
            {
                if (BasicInformationManagementCtrl.UpdateRewardClassName(id, newName, ref exception))
                {
                    Alert.ShowInTop("修改成功！", MessageBoxIcon.Information);
                    PageContext.RegisterStartupScript(ActiveWindow.GetHideReference());
                }
                else
                {
                    Alert.ShowInTop("修改失败！\n原因：" + exception, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                Alert.ShowInTop("来源不明！", MessageBoxIcon.Error);
                return;
            }
        }
        #endregion
    }
}