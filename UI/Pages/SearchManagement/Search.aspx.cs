using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQS.Controller;
using FineUI;
using SQS.DataStructure;

namespace SQS.UI.Pages.SearchManagement
{
    public partial class Search : System.Web.UI.Page
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindYearsToDropDownList();
            }
        }
        #endregion

        #region Event
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
        private void bindPaperInformationToGrid()
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