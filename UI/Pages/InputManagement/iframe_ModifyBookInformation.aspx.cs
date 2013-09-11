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
    public partial class iframe_ModifyBookInformation : PageBase
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

                loadBook();
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
            loadBook();
            DropDownList_Office.Enabled = false;
        }

        protected void Button_Update_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Id = ViewState["id"].ToString();
            book.Name = TextBox_Name.Text;
            book.BookName = TextBox_BookName.Text;
            book.Press = TextBox_Press.Text;
            book.PublishDate = DatePicker_PublishDate.Text;
            book.PublishGradeId = DropDownList_PublishGrade.SelectedValue;
            book.RewardGradeId = DropDownList_RewardGrade.SelectedValue;
            book.RewardClassId = DropDownList_RewardClass.SelectedValue;
            book.WordCount = Convert.ToInt32(NumberBox_WordCount.Text.Trim());
            book.AutherCount = Convert.ToInt32(NumberBox_AutherCount.Text.Trim());
            book.AutherOrder = Convert.ToInt32(DropDownList_AutherOrder.SelectedValue);

            string exception = "";
            if(InputManagementCtrl.UpdateBook(book, ref exception))
            {
                Alert.ShowInTop("更新成功！\n窗口即将关闭", MessageBoxIcon.Information);
                PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());
            }
        }
        #endregion

        #region Private Method
        /// <summary>
        /// 载入著作信息
        /// </summary>
        private void loadBook()
        {
            string id = ViewState["id"].ToString();
            string exception = "";
            Book book = new Book();
            if (InputManagementCtrl.GetBookById(ref book, id, ref exception))
            {
                DropDownList_Depart.SelectedValue = book.DepartId;
                DropDownList_Office.SelectedValue = book.OfficeId;
                TextBox_Name.Text = book.Name;
                TextBox_BookName.Text = book.BookName;
                TextBox_Press.Text = book.Press;
                DatePicker_PublishDate.SelectedDate = (Convert.ToDateTime(book.PublishDate));
                DropDownList_PublishGrade.SelectedValue = book.PublishGradeId;
                DropDownList_RewardGrade.SelectedValue = book.RewardGradeId;
                DropDownList_RewardClass.SelectedValue = book.RewardClassId;
                NumberBox_WordCount.Text = book.WordCount.ToString();
                NumberBox_AutherCount.Text = book.AutherCount.ToString();
                DropDownList_AutherOrder.SelectedValue = book.AutherOrder.ToString();
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
            if (CommonCtrl.GetPublishGradeIdNameDicForBook(ref idNameDic, ref exception))
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