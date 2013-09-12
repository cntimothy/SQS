using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQS.DataStructure;
using SQS.Controller;
using FineUI;
using System.Data;

namespace SQS.UI.Pages.BasicInformationManagement
{
    public partial class GradeManegement : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindPublishGradeForPaperToGrid();
                bindPublishGradeForBookToGrid();
                bindTopicGradeToGrid();
                bindRewardGradeToGrid();
                bindRewardClassToGrid();
            }
        }
        #endregion

        #region Event
        #endregion

        #region Private Method
        /// <summary>
        /// 绑定论文发表级别
        /// </summary>
        private void bindPublishGradeForPaperToGrid()
        {
            string exception = "";
            DataTable table = new DataTable();
            if (BasicInformationManagementCtrl.GetPublishGradeForPaper(ref table, ref exception))
            {
                Grid_PublishGradeForPaper.DataSource = table;
                Grid_PublishGradeForPaper.DataBind();
            }
        }

        /// <summary>
        /// 绑定著作发行级别
        /// </summary>
        private void bindPublishGradeForBookToGrid()
        {
            string exception = "";
            DataTable table = new DataTable();
            if (BasicInformationManagementCtrl.GetPublishGradeForBook(ref table, ref exception))
            {
                Grid_PublishGradeForBook.DataSource = table;
                Grid_PublishGradeForBook.DataBind();
            }
        }

        /// <summary>
        /// 绑定课题级别
        /// </summary>
        private void bindTopicGradeToGrid()
        {
            string exception = "";
            DataTable table = new DataTable();
            if (BasicInformationManagementCtrl.GetTopicGrade(ref table, ref exception))
            {
                Grid_TopicGrade.DataSource = table;
                Grid_TopicGrade.DataBind();
            }
        }

        /// <summary>
        /// 绑定获奖级别
        /// </summary>
        private void bindRewardGradeToGrid()
        {
            string exception = "";
            DataTable table = new DataTable();
            if (BasicInformationManagementCtrl.GetRewardGrade(ref table, ref exception))
            {
                Grid_RewardGrade.DataSource = table;
                Grid_RewardGrade.DataBind();
            }
        }

        /// <summary>
        /// 绑定获奖等级
        /// </summary>
        private void bindRewardClassToGrid()
        {
            string exception = "";
            DataTable table = new DataTable();
            if (BasicInformationManagementCtrl.GetRewardClass(ref table, ref exception))
            {
                Grid_RewardClass.DataSource = table;
                Grid_RewardClass.DataBind();
            }
        }
        #endregion
    }
}