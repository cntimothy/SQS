using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using SQS.DataStructure;
using SQS.Controller;
using System.Data;

namespace SQS.UI.Pages.InputManagement
{
    public partial class iframe_ModifyTopicInformation : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //注册关闭按钮事件
                Button_Close.OnClientClick = ActiveWindow.GetConfirmHideRefreshReference();
                bindDepartToDropDownList();
                bindOfficeToDropDownList();
                bindTopicGradeToDropDownList();
                bindRewardGradeToDropDownList();
                bindRewardClassToDropDownList();

                ViewState["id"] = Request.QueryString["id"];

                loadTopic();
            }
        }
        #endregion

        #region Event
        protected void DropDownList_Depart_SelectedChanged(object sender, EventArgs e)
        {
            DropDownList_Office.Enabled = true;
            bindOfficeToDropDownList();
        }

        /// <summary>
        /// 重置事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Reset_Click(object sender, EventArgs e)
        {
            loadTopic();
            DropDownList_Office.Enabled = false;
        }

        protected void Button_Update_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.Id = ViewState["id"].ToString();
            topic.DepartId = DropDownList_Depart.SelectedValue;
            topic.OfficeId = DropDownList_Office.SelectedValue;
            topic.Name = TextBox_Name.Text.Trim();
            topic.TopicName = TextBox_TopicName.Text.Trim();
            topic.TopicGradeId = DropDownList_TopicGrade.SelectedValue;
            topic.StartTime = DatePicker_StartTime.Text.Trim();
            topic.StopTime = DatePicker_StopTime.Text.Trim();
            topic.RewardGradeId = DropDownList_RewardGrade.SelectedValue;
            topic.RewardClassId = DropDownList_RewardClass.SelectedValue;
            topic.CompleteType = TextBox_CompleteType.Text.Trim();
            topic.WordCount = Convert.ToInt32(NumberBox_WordCount.Text.Trim());
            topic.AutherCount = Convert.ToInt32(NumberBox_AutherCount.Text.Trim());
            topic.AutherOrder = Convert.ToInt32(DropDownList_AutherOrder.SelectedValue);

            string exception = "";
            if (InputManagementCtrl.UpdateTopic(topic, ref exception))
            {
                Alert.ShowInTop("更新成功！\n窗口即将关闭", MessageBoxIcon.Information);
                PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
            }
            else
            {
                Alert.ShowInTop("更新失败！\n原因：" + exception, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Private Method
        /// <summary>
        /// 载入课题信息
        /// </summary>
        private void loadTopic()
        {
            string id = ViewState["id"].ToString();
            string exception = "";
            Topic topic = new Topic();
            if (InputManagementCtrl.GetTopicById(ref topic, id, ref exception))
            {
                DropDownList_Depart.SelectedValue = topic.DepartId;
                DropDownList_Office.SelectedValue = topic.OfficeId;
                TextBox_Name.Text = topic.Name;
                TextBox_TopicName.Text = topic.TopicName;
                DropDownList_TopicGrade.SelectedValue = topic.TopicGradeId;
                DatePicker_StartTime.SelectedDate = (Convert.ToDateTime(topic.StartTime));
                DatePicker_StopTime.SelectedDate = (Convert.ToDateTime(topic.StopTime));
                DropDownList_RewardGrade.SelectedValue = topic.RewardGradeId;
                DropDownList_RewardClass.SelectedValue = topic.RewardClassId;
                TextBox_CompleteType.Text = topic.CompleteType;
                NumberBox_WordCount.Text = topic.WordCount.ToString();
                NumberBox_AutherCount.Text = topic.AutherCount.ToString();
                DropDownList_AutherOrder.SelectedValue = topic.AutherOrder.ToString();
            }
        }

        /// <summary>
        /// 载入部系
        /// </summary>
        private void bindDepartToDropDownList()
        {
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
        /// 载入处室
        /// </summary>
        private void bindOfficeToDropDownList()
        {
            string exception = "";
            Dictionary<string, string> idNameDic = new Dictionary<string, string>();
            string departId = DropDownList_Depart.SelectedValue;
            if (CommonCtrl.GetOfficeIdNameDicByDepartId(ref idNameDic, departId, ref exception))
            {
                foreach (string id in idNameDic.Keys)
                {
                    DropDownList_Office.Items.Add(idNameDic[id], id);
                }
            }
        }

        /// <summary>
        /// 绑定课题级别
        /// </summary>
        private void bindTopicGradeToDropDownList()
        {
            string exception = "";
            Dictionary<string, string> idNameDic = new Dictionary<string, string>();
            if (CommonCtrl.GetTopicGradeIdNameDic(ref idNameDic, ref exception))
            {
                foreach (string id in idNameDic.Keys)
                {
                    DropDownList_TopicGrade.Items.Add(idNameDic[id], id);
                }
            }
        }

        /// <summary>
        /// 绑定奖励级别
        /// </summary>
        private void bindRewardGradeToDropDownList()
        {
            string exception = "";
            Dictionary<string, string> idNameDic = new Dictionary<string, string>();
            if (CommonCtrl.GetRewardGradeIdNameDic(ref idNameDic, ref exception))
            {
                foreach (string id in idNameDic.Keys)
                {
                    DropDownList_RewardGrade.Items.Add(idNameDic[id], id);
                }
            }
        }

        /// <summary>
        /// 绑定奖励等级
        /// </summary>
        private void bindRewardClassToDropDownList()
        {
            string exception = "";
            Dictionary<string, string> idNameDic = new Dictionary<string, string>();
            if (CommonCtrl.GetRewardClassIdNameDic(ref idNameDic, ref exception))
            {
                foreach (string id in idNameDic.Keys)
                {
                    DropDownList_RewardClass.Items.Add(idNameDic[id], id);
                }
            }
        }
        #endregion
    }
}