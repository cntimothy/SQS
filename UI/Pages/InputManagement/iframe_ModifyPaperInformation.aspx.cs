using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using SQS.Controller;
using SQS.DataStructure;

namespace SQS.UI.Pages.InputManagement
{
    public partial class iframe_ModifyPaperInformation : System.Web.UI.Page
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
                bindPublishGradeToDropDownList();
                bindRewardGradeToDropDownList();
                bindRewardClassToDropDownList();

                ViewState["id"] = Request.QueryString["id"];

                loadPaper();
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
            loadPaper();
            DropDownList_Office.Enabled = false;
        }

        protected void Button_Update_Click(object sender, EventArgs e)
        {
            Paper paper = new Paper();
            paper.Id = ViewState["id"].ToString();
            paper.DepartId = DropDownList_Depart.SelectedValue;
            paper.OfficeId = DropDownList_Office.SelectedValue;
            paper.Name = TextBox_Name.Text.Trim();
            paper.PaperName = TextBox_PaperName.Text.Trim();
            paper.JournalName = TextBox_JournalName.Text.Trim();
            paper.PublishDate = DatePicker_PublishDate.Text.Trim();
            paper.PublishGradeId = DropDownList_PublishGrade.SelectedValue;
            paper.RewardGradeId = DropDownList_RewardGrade.SelectedValue;
            paper.RewardClassId = DropDownList_RewardClass.SelectedValue;
            paper.WordCount = Convert.ToInt32(NumberBox_WordCount.Text.Trim());
            paper.AutherCount = Convert.ToInt32(NumberBox_AutherCount.Text.Trim());
            paper.AutherOrder = Convert.ToInt32(DropDownList_AutherOrder.SelectedValue);

            string exception = "";
            if (InputManagementCtrl.UpdatePaper(paper, ref exception))
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
        /// 载入著作信息
        /// </summary>
        private void loadPaper()
        {
            string id = ViewState["id"].ToString();
            string exception = "";
            Paper paper = new Paper();
            if (InputManagementCtrl.GetPaperById(ref paper, id, ref exception))
            {
                DropDownList_Depart.SelectedValue = paper.DepartId;
                DropDownList_Office.SelectedValue = paper.OfficeId;
                TextBox_Name.Text = paper.Name;
                TextBox_PaperName.Text = paper.PaperName;
                TextBox_JournalName.Text = paper.JournalName;
                DatePicker_PublishDate.SelectedDate = (Convert.ToDateTime(paper.PublishDate));
                DropDownList_PublishGrade.SelectedValue = paper.PublishGradeId;
                DropDownList_RewardGrade.SelectedValue = paper.RewardGradeId;
                DropDownList_RewardClass.SelectedValue = paper.RewardClassId;
                NumberBox_WordCount.Text = paper.WordCount.ToString();
                NumberBox_AutherCount.Text = paper.AutherCount.ToString();
                DropDownList_AutherOrder.SelectedValue = paper.AutherOrder.ToString();
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
        /// 绑定发行级别
        /// </summary>
        private void bindPublishGradeToDropDownList()
        {
            string exception = "";
            Dictionary<string, string> idNameDic = new Dictionary<string, string>();
            if (CommonCtrl.GetPublishGradeIdNameDicForPaper(ref idNameDic, ref exception))
            {
                foreach (string id in idNameDic.Keys)
                {
                    DropDownList_PublishGrade.Items.Add(idNameDic[id], id);
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